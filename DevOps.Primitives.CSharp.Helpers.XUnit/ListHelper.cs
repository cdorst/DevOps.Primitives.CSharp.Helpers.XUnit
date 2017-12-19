using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    internal static class ListHelper
    {
        public static bool Any<T>(IEnumerable<T> items)
            => items?.Any() ?? false;
    }
}
