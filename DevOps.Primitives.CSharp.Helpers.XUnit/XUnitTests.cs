using DevOps.Primitives.CSharp.Helpers.Common;
using System.Collections.Generic;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public static class XUnitTests
    {
        public static Method Create(
            string name,
            IEnumerable<Statement> arrange,
            IEnumerable<Statement> act,
            IEnumerable<Statement> assert,
            XUnitTheory theory = null,
            bool isAsync = false)
            => new Method(
                name,
                GetType(isAsync),
                XUnitTestParameters.Create(theory),
                XUnitTestBlocks.Create(arrange, act, assert),
                GetModifiers(isAsync),
                attributes: XUnitTestAttributes.Create(theory));

        public static Method Create(XUnitTest test)
            => Create(test.Name, test.Arrange, test.Act, test.Assert, test.Theory, test.IsAsync);

        private static ModifierList GetModifiers(bool isAsync)
            => isAsync ? ModifierLists.PublicAsync : ModifierLists.Public;

        private static string GetType(bool isAsync)
            => isAsync ? TypeConstants.Task : TypeConstants.Void;
    }
}
