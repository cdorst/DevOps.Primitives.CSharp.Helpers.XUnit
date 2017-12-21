using DevOps.Primitives.NuGet;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public static class PackageReferences
    {
        public static NuGetReference MicrosoftNetTestSdk() => new NuGetReference("Microsoft.NET.Test.Sdk", "15.5.0");
        public static NuGetReference XUnit() => new NuGetReference("xunit", "2.3.1");
        public static NuGetReference XUnitRunnerVisualStudio() => new NuGetReference("xunit", "2.3.1");

    }
}
