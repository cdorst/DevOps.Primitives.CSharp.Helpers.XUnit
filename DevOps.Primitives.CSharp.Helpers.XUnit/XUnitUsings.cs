using DevOps.Primitives.CSharp.Helpers.Common;
using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public static class XUnitUsings
    {
        private static string Xunit = nameof(Xunit);

        public static UsingDirectiveList Create(IEnumerable<string> usingDirectives)
            => UsingDirectiveLists.Create(
                GetUsings(usingDirectives));

        private static string[] GetUsings(IEnumerable<string> usings)
            => usings.Union(new string[] { Xunit }).ToArray();
    }
}
