Release Notes
====

# 08-XX-209
<a href="https://www.nuget.org/packages/dotnext/0.12.0">DotNext 0.12.0</a><br/>
* Value (struct) Delegates are introduced as allocation-free alternative to classic delegates
* Atomic&lt;T&gt; is added to provide atomic memory access operations for arbitrary value types
* Arithmetic, bitwise and comparison operations for [IntPtr](https://docs.microsoft.com/en-us/dotnet/api/system.intptr) and [UIntPtr](https://docs.microsoft.com/en-us/dotnet/api/system.uintptr)
* Improved performance of methods declared in [EnumConverter](https://sakno.github.io/dotNext/api/DotNext.EnumConverter.html)
* Improved performance of atomic operations
* Improved performance of bitwise equality and bitwise comparison methods for value types
* Improved performance of [IsDefault](https://sakno.github.io/dotNext/api/DotNext.ValueType-1.html#DotNext_ValueType_1_IsDefault__0_) method which allows to check whether the arbitrary value type `T` is `default(T)`
* GetUnderlyingType() method is added to obtain underlying type of Result&lt;T&gt;
* [TypedReference](https://sakno.github.io/dotNext/api/DotNext.ValueType-1.html#DotNext_ValueType_1_IsDefault__0_) can be converted into managed pointer (type T&amp;, or ref T) using [Memory](https://sakno.github.io/dotNext/api/DotNext.Runtime.InteropServices.Memory.html) class

This release introduces a new feature called Value Delegates which are allocation-free alternative to regular .NET delegates. Value Delegate is a value type which holds a pointer to the managed method and can be invoked using `Invoke` method in the same way as regular .NET delegate. Read more [here](https://sakno.github.io/dotNext/features/core/valued.html)

<a href="https://www.nuget.org/packages/dotnext.reflection/0.12.0">DotNext.Reflection 0.12.0</a><br/>
* Ability to obtain managed pointer (type T&amp;, or `ref T`) to static or instance field from [FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.fieldinfo) using [Reflector](https://sakno.github.io/dotNext/api/DotNext.Reflection.Reflector.html) class

<a href="https://www.nuget.org/packages/dotnext.threading/0.12.0">DotNext.Threading 0.12.0</a><br/>
* [AsyncLazy&lt;T&gt;](https://sakno.github.io/dotNext/api/DotNext.Threading.AsyncLazy-1.html) is introduced as asynchronous alternative to [Lazy&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.lazy-1) class

<a href="https://www.nuget.org/packages/dotnext.metaprogramming/0.12.0">DotNext.Metaprogramming 0.12.0</a><br/>
* [Null-safe navigation expression](https://sakno.github.io/dotNext/api/DotNext.Linq.Expressions.NullSafetyExpression.html) is introduced

<a href="https://www.nuget.org/packages/dotnext.unsafe/0.12.0">DotNext.Unsafe 0.12.0</a><br/>
* [UnmanagedFunction](https://sakno.github.io/dotNext/api/DotNext.Runtime.InteropServices.UnmanagedFunction.html) and [UnmanagedFunction&lt;R&gt;]((https://sakno.github.io/dotNext/api/DotNext.Runtime.InteropServices.UnmanagedFunction-1.html) classes are introduced to call unmanaged functions by pointer

<a href="https://www.nuget.org/packages/dotnext.net.cluster/0.12.0">DotNext.Net.Cluster 0.2.0</a><br/>
<a href="https://www.nuget.org/packages/dotnext.aspnetcore.cluster/0.12.0">DotNext.AspNetCore.Cluster 0.2.0</a><br/>
* Raft client is now capable to ensure that changes are committed by leader node using [WriteConcern](https://sakno.github.io/dotNext/api/DotNext.Net.Cluster.Replication.WriteConcern.html)

