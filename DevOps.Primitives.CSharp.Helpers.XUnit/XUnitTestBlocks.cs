using DevOps.Primitives.CSharp.Helpers.Common;
using System.Collections.Generic;
using System.Linq;
using static DevOps.Primitives.CSharp.Helpers.XUnit.ListHelper;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public static class XUnitTestBlocks
    {
        private const string Act = nameof(Act);
        private const string Arrange = nameof(Arrange);
        private const string Assert = nameof(Assert);

        public static Block Create(
            IEnumerable<Statement> arrange,
            IEnumerable<Statement> act,
            IEnumerable<Statement> assert)
        {
            var statements = new List<Statement>();
            if (Any(arrange)) statements.AddRange(Label(Arrange, arrange));
            if (Any(act)) statements.AddRange(Label(Act, act));
            if (Any(assert)) statements.AddRange(Label(Assert, assert));
            return Blocks.Create(statements.ToArray());
        }

        private static IEnumerable<Statement> Label(string label, IEnumerable<Statement> statements)
        {
            for (int i = 0; i < statements.Count(); i++)
            {
                var statement = statements.ElementAt(i);
                if (i == 0)
                {
                    statement.Text.Value = $"// {label}\r\n{statement.Text.Value}";
                }
                yield return statement;
            }
        }
    }
}
