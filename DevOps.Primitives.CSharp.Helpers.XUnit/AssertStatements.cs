using System.Collections.Generic;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public static class AssertStatements
    {
        public static IEnumerable<Statement> Create(params Statement[] statements)
            => statements;
    }
}
