using System.Collections.Generic;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public class XUnitTest
    {
        public string Name { get; set; }
        public IEnumerable<Statement> Arrange { get; set; }
        public IEnumerable<Statement> Act { get; set; }
        public IEnumerable<Statement> Assert { get; set; }
        public XUnitTheory Theory { get; set; }
        public bool IsAsync { get; set; }
    }
}
