using DevOps.Primitives.NuGet;
using System.Collections.Generic;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public static class XUnitNuGetReferences
    {
        public static IEnumerable<NuGetReference> GetReferences()
        {
            yield return PackageReferences.MicrosoftNetTestSdk();
            yield return PackageReferences.XUnit();
            yield return PackageReferences.XUnitRunnerVisualStudio();
            yield return DotNetCliToolReferences.DotNetXUnit();
        }
    }
}
