using DevOps.Primitives.NuGet;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public static class DotNetCliToolReferences
    {
        public static NuGetReference DotNetXUnit() => new NuGetReference("dotnet-xunit", "2.3.1", ReferenceType.DotNetCliToolReference);
    }
}
