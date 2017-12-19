using DevOps.Primitives.CSharp.Helpers.Common;
using System.Collections.Generic;
using System.Linq;
using static DevOps.Primitives.CSharp.Helpers.XUnit.ListHelper;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public static class XUnitTestParameters
    {
        public static ParameterList Create(XUnitTheory theory)
            => !Any(theory?.Parameters) ? null
            : ParameterLists.Create(
                GetParameters(theory.Parameters).ToArray());

        private static IEnumerable<Parameter> GetParameters(IEnumerable<XUnitTheoryParameter> parameters)
        {
            foreach (var parameter in parameters)
                yield return new Parameter(parameter.Name, parameter.Type);
        }
    }
}
