﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace DotNext.Reflection
{
    [ExcludeFromCodeCoverage]
    public sealed class CollectionTypeTests : Test
    {
        [Fact]
        public static void GetItemTypeTest()
        {
            Equal(typeof(long), typeof(long[]).GetItemType());
            Equal(typeof(bool), typeof(IList<bool>).GetItemType());
        }
    }
}
