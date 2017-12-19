using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    internal static class AssertHelper
    {
        private const string ArgSeperator = ", ";

        public static Statement Assert(string method, string typeArgs, params string[] args)
            => new Statement(
                $"{nameof(Assert)}.{method}{GetOptionalTypeArg(typeArgs)}({GetArgs(args)});");

        private static string GetArgs(params string[] args)
            => string.Join(ArgSeperator,
                args.Where(arg => !string.IsNullOrWhiteSpace(arg)));

        private static string GetOptionalTypeArg(string typeLiteral)
            => string.IsNullOrWhiteSpace(typeLiteral)
                ? string.Empty
                : $"<{typeLiteral}>";
    }
}
