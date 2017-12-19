using DevOps.Primitives.CSharp.Helpers.Common;
using System.Collections.Generic;
using System.Linq;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public static class XUnitTestAttributes
    {
        public static AttributeListCollection Create(XUnitTheory theory)
            => AttributeLists.Create(GetAttributes(theory));

        private static Attribute[] GetAttributes(XUnitTheory theory)
            => theory == null
            ? new Attribute[] { XUnitAttributes.Fact() }
            : GetTheoryAttributes(theory).ToArray();

        private static IEnumerable<Attribute> GetTheoryAttributes(XUnitTheory theory)
        {
            yield return XUnitAttributes.Theory();

            var memberData = theory.MemberDataNameOfLiteral;
            if (!string.IsNullOrWhiteSpace(memberData))
            {
                yield return XUnitAttributes.MemberData(memberData);
                yield break;
            }

            foreach (var literal in theory.InlineDataLiterals)
                yield return XUnitAttributes.InlineData(literal);
        }
    }
}
