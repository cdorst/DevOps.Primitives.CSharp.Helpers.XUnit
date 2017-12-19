namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public static class XUnitAttributes
    {
        public static Attribute Fact() => new Attribute(nameof(Fact));
        public static Attribute InlineData(string argumentsExpression) => new Attribute(nameof(InlineData), argumentsExpression);
        public static Attribute MemberData(string nameofLiteral) => new Attribute(nameof(MemberData), $"nameof({nameofLiteral})");
        public static Attribute Theory() => new Attribute(nameof(Theory));
    }
}
