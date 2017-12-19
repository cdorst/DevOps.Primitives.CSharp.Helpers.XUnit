using DevOps.Primitives.CSharp.Helpers.Common;
using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public static class XUnitTestClasses
    {
        public static ClassDeclaration Create(
            string name,
            string @namespace,
            IEnumerable<Method> tests,
            IEnumerable<string> usingDirectives)
            => new ClassDeclaration(
                name,
                @namespace,
                ModifierLists.Public,
                XUnitUsings.Create(usingDirectives),
                methodList: MethodLists.Create(tests.ToArray()));

        public static ClassDeclaration Create(
            string name,
            string @namespace,
            IEnumerable<XUnitTest> tests,
            IEnumerable<string> usingDirectives)
            => Create(
                name,
                @namespace,
                tests.Select(test => XUnitTests.Create(test)),
                usingDirectives);
    }
}
