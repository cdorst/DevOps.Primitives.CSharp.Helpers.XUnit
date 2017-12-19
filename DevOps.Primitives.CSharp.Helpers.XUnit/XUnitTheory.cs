using System.Collections.Generic;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public class XUnitTheory
    {
        public IEnumerable<string> InlineDataLiterals { get; set; }
        public string MemberDataNameOfLiteral { get; set; }
        public IEnumerable<XUnitTheoryParameter> Parameters { get; set; }
    }
}
