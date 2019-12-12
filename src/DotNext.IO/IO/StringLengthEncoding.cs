﻿namespace DotNext.IO
{
    /// <summary>
    /// Describes how string length should be encoded in binary form.
    /// </summary>
    public enum StringLengthEncoding : byte
    {
        /// <summary>
        /// Use 32-bit integer value to represent string length.
        /// </summary>
        /// <remarks>
        /// This format provides the best performance.
        /// </remarks>
        Plain,

        /// <summary>
        /// Use 7-bit encoded compressed integer value to represent string length.
        /// </summary>
        /// <remarks>
        /// This format provides optimized binary size.
        /// </remarks>
        Compressed
    }
}
