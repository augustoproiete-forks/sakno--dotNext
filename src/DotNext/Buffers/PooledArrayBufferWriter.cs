using System;
using System.Buffers;
using System.IO;

namespace DotNext.Buffers
{
    /// <summary>
    /// Represents memory writer that is backed by the array obtained from the pool.
    /// </summary>
    /// <remarks>
    /// This class provides additional methods for access to array segments in contrast to <see cref="PooledBufferWriter{T}"/>. 
    /// </remarks>
    /// <typeparam name="T">The data type that can be written.</typeparam>
    public sealed class PooledArrayBufferWriter<T> : MemoryWriter<T>, IConvertible<ArraySegment<T>>
    {
        private readonly ArrayPool<T> pool;
        private T[] buffer;

        /// <summary>
        /// Initializes a new writer with the specified initial capacity.
        /// </summary>
        /// <param name="pool">The array pool.</param>
        /// <param name="initialCapacity">The initial capacity of the writer.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="initialCapacity"/> is less than or equal to zero.</exception>
        public PooledArrayBufferWriter(ArrayPool<T> pool, int initialCapacity)
        {
            if(initialCapacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(initialCapacity));
            this.pool = pool;
            buffer = pool.Rent(initialCapacity);
        }

        /// <summary>
        /// Initializes a new writer with the default initial capacity.
        /// </summary>
        /// <param name="pool">The array pool.</param>
        public PooledArrayBufferWriter(ArrayPool<T> pool)
        {
            this.pool = pool;
            buffer = Array.Empty<T>();
        }

        /// <summary>
        /// Initializes a new writer with the default initial capacity and <see cref="ArrayPool{T}.Shared"/>
        /// as the array pooling mechanism.
        /// </summary>
        public PooledArrayBufferWriter()
            : this(ArrayPool<T>.Shared)
        {
        }

        /// <summary>
        /// Gets the total amount of space within the underlying memory.
        /// </summary>
        /// <exception cref="ObjectDisposedException">This writer has been disposed.</exception>
        public override int Capacity
        {
            get
            {
                ThrowIfDisposed();
                return buffer.Length;
            }
        }

        /// <summary>
        /// Gets the data written to the underlying buffer so far.
        /// </summary>
        /// <exception cref="ObjectDisposedException">This writer has been disposed.</exception>
        public override ReadOnlyMemory<T> WrittenMemory
        {
            get
            {
                ThrowIfDisposed();
                return new Memory<T>(buffer, 0, position);
            }
        }

        /// <summary>
        /// Gets the daya written to the underlying array so far.
        /// </summary>
        /// <exception cref="ObjectDisposedException">This writer has been disposed.</exception>
        public ArraySegment<T> WrittenArray
        {
            get
            {
                ThrowIfDisposed();
                return new ArraySegment<T>(buffer, 0, position);
            }
        }

        ArraySegment<T> IConvertible<ArraySegment<T>>.Convert() => WrittenArray;

        internal TWrapper WrapBuffer<TWrapper>(ValueFunc<T[], int, TWrapper> factory) 
            => factory.Invoke(buffer, position);

        /// <summary>
        /// Clears the data written to the underlying buffer.
        /// </summary>
        /// <exception cref="ObjectDisposedException">This writer has been disposed.</exception>
        public override void Clear()
        {
            if(buffer.Length > 0)
                pool.Return(buffer);
            position = 0;
        }

        /// <summary>
        /// Returns the memory to write to that is at least the requested size.
        /// </summary>
        /// <param name="sizeHint">The minimum length of the returned memory.</param>
        /// <returns>The memory block of at least the size <paramref name="sizeHint"/>.</returns>
        /// <exception cref="OutOfMemoryException">The requested buffer size is not available.</exception>
        /// <exception cref="ObjectDisposedException">This writer has been disposed.</exception>
        public override Memory<T> GetMemory(int sizeHint = 0)
        {
            CheckAndResizeBuffer(sizeHint);
            return buffer.AsMemory(position);
        }

        /// <summary>
        /// Returns the memory to write to that is at least the requested size.
        /// </summary>
        /// <param name="sizeHint">The minimum length of the returned memory.</param>
        /// <returns>The memory block of at least the size <paramref name="sizeHint"/>.</returns>
        /// <exception cref="OutOfMemoryException">The requested buffer size is not available.</exception>
        /// <exception cref="ObjectDisposedException">This writer has been disposed.</exception>
        public override Span<T> GetSpan(int sizeHint = 0)
        {
            CheckAndResizeBuffer(sizeHint);
            return buffer.AsSpan(position);
        }

        /// <summary>
        /// Returns the memory to write to that is at least the requested size.
        /// </summary>
        /// <param name="sizeHint">The minimum length of the returned memory.</param>
        /// <returns>The memory block of at least the size <paramref name="sizeHint"/>.</returns>
        /// <exception cref="OutOfMemoryException">The requested buffer size is not available.</exception>
        /// <exception cref="ObjectDisposedException">This writer has been disposed.</exception>
        public ArraySegment<T> GetArray(int sizeHint = 0)
        {
            CheckAndResizeBuffer(sizeHint);
            return new ArraySegment<T>(buffer, position, buffer.Length - position);
        }

        private protected override void Resize(int newSize)
        {
            var newBuffer = pool.Rent(newSize);
            buffer.CopyTo(newBuffer, 0);
            pool.Return(buffer);
            buffer = newBuffer;
        }

        /// <summary>
        /// Returns the memory used by this writer back to the pool.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(buffer.Length > 0)
                    pool.Return(buffer);
                buffer = Array.Empty<T>();
            }
            base.Dispose(disposing);
        }
    }

    /// <summary>
    /// Represents extension methods for <see cref="PooledArrayBufferWriter{T}"/> class.
    /// </summary>
    public static class PooledArrayBufferWriter
    {
        /// <summary>
        /// Gets written content as read-only stream.
        /// </summary>
        /// <param name="writer">The buffer writer.</param>
        /// <returns>The stream representing written bytes.</returns>
        [Obsolete("Use DotNext.IO.StreamSource.AsStream instead")]
        public static Stream GetWrittenBytesAsStream(this PooledArrayBufferWriter<byte> writer)
            => IO.StreamSource.AsStream(writer);
    }
}