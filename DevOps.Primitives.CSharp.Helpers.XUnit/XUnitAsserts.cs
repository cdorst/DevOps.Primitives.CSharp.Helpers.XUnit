using static DevOps.Primitives.CSharp.Helpers.XUnit.AssertHelper;

namespace DevOps.Primitives.CSharp.Helpers.XUnit
{
    public static class XUnitAsserts
    {
        public static Statement All(
            string collectionLiteral,
            string actionLiteral,
            string typeLiteral = null)
            => Assert(nameof(All),
                typeLiteral,
                collectionLiteral,
                actionLiteral);

        public static Statement Collection(
            string collectionLiteral,
            string elementInspectorsLiteral,
            string typeLiteral = null)
            => Assert(nameof(Collection),
                typeLiteral,
                collectionLiteral,
                elementInspectorsLiteral);

        public static Statement Contains(
            string arg1Literal,
            string arg2Literal,
            string arg3Literal = null,
            string typeLiteral = null)
            => Assert(nameof(Contains),
                typeLiteral,
                arg1Literal,
                arg2Literal,
                arg3Literal);

        public static Statement DoesNotContain(
            string arg1Literal,
            string arg2Literal,
            string arg3Literal = null,
            string typeLiteral = null)
            => Assert(nameof(DoesNotContain),
                typeLiteral,
                arg1Literal,
                arg2Literal,
                arg3Literal);

        public static Statement DoesNotMatch(
            string arg1Literal,
            string arg2Literal)
            => Assert(nameof(DoesNotMatch),
                typeArgs: null,
                arg1Literal,
                arg2Literal);

        public static Statement Empty(
            string collectionLiteral)
            => Assert(nameof(Empty),
                typeArgs: null,
                collectionLiteral);

        public static Statement EndsWith(
            string expectedEndStringLiteral,
            string actualStringLiteral,
            string comparisonTypeLiteral = null)
            => Assert(nameof(EndsWith),
                typeArgs: null,
                expectedEndStringLiteral,
                actualStringLiteral,
                comparisonTypeLiteral);

        public static Statement Equal(
            string arg1Literal,
            string arg2Literal,
            string arg3Literal = null,
            string arg4Literal = null,
            string arg5Literal = null,
            string typeLiteral = null)
            => Assert(nameof(Equal),
                typeLiteral,
                arg1Literal,
                arg2Literal,
                arg3Literal,
                arg4Literal,
                arg5Literal);

        public static Statement False(
            string conditionLiteral,
            string userMessageLiteral = null)
            => Assert(nameof(False),
                typeArgs: null,
                conditionLiteral,
                userMessageLiteral);

        public static Statement InRange(
            string actualLiteral,
            string lowLiteral,
            string highLiteral,
            string comparerLiteral = null,
            string typeLiteral = null)
            => Assert(nameof(InRange),
                typeLiteral,
                actualLiteral,
                lowLiteral,
                highLiteral,
                comparerLiteral);

        public static Statement IsAssignableFrom(
            string arg1Literal,
            string arg2Literal = null,
            string typeLiteral = null)
            => Assert(nameof(IsAssignableFrom),
                typeLiteral,
                arg1Literal,
                arg2Literal);

        public static Statement IsNotType(
            string arg1Literal,
            string arg2Literal = null,
            string typeLiteral = null)
            => Assert(nameof(IsNotType),
                typeLiteral,
                arg1Literal,
                arg2Literal);

        public static Statement IsType(
            string arg1Literal,
            string arg2Literal = null,
            string typeLiteral = null)
            => Assert(nameof(IsType),
                typeLiteral,
                arg1Literal,
                arg2Literal);

        public static Statement Matches(
            string exprectedRegexArgLiteral,
            string actualStringLiteral,
            string typeLiteral = null)
            => Assert(nameof(Matches),
                typeLiteral,
                exprectedRegexArgLiteral,
                actualStringLiteral);

        public static Statement NotEmpty(
            string collectionLiteral)
            => Assert(nameof(NotEmpty),
                typeArgs: null,
                collectionLiteral);

        public static Statement NotEqual(
            string arg1Literal,
            string arg2Literal,
            string arg3Literal = null,
            string typeLiteral = null)
            => Assert(nameof(NotEqual),
                typeLiteral,
                arg1Literal,
                arg2Literal,
                arg3Literal);

        public static Statement NotInRange(
            string actualLiteral,
            string lowLiteral,
            string highLiteral,
            string comparerLiteral = null,
            string typeLiteral = null)
            => Assert(nameof(NotInRange),
                typeLiteral,
                actualLiteral,
                lowLiteral,
                highLiteral,
                comparerLiteral);

        public static Statement NotNull(
            string objectLiteral)
            => Assert(nameof(NotNull),
                typeArgs: null,
                objectLiteral);

        public static Statement NotSame(
            string object1Literal,
            string object2Literal)
            => Assert(nameof(NotSame),
                typeArgs: null,
                object1Literal,
                object2Literal);

        public static Statement NotStrictEqual(
            string object1Literal,
            string object2Literal,
            string typeLiteral = null)
            => Assert(nameof(NotStrictEqual),
                typeLiteral,
                object1Literal,
                object2Literal);

        public static Statement Null(
            string objectLiteral)
            => Assert(nameof(Null),
                typeArgs: null,
                objectLiteral);

        public static Statement ProperSubset(
            string expectedLiteral,
            string actualLiteral,
            string typeLiteral = null)
            => Assert(nameof(ProperSubset),
                typeLiteral,
                expectedLiteral,
                actualLiteral);

        public static Statement ProperSuperset(
            string expectedLiteral,
            string actualLiteral,
            string typeLiteral = null)
            => Assert(nameof(ProperSuperset),
                typeLiteral,
                expectedLiteral,
                actualLiteral);

        public static Statement PropertyChanged(
            string objectLiteral,
            string propertyNameLiteral,
            string testCodeLiteral)
            => Assert(nameof(PropertyChanged),
                typeArgs: null,
                objectLiteral,
                propertyNameLiteral,
                testCodeLiteral);

        public static Statement PropertyChangedAsync(
            string objectLiteral,
            string propertyNameLiteral,
            string testCodeLiteral)
            => Await(Assert(nameof(PropertyChangedAsync),
                typeArgs: null,
                objectLiteral,
                propertyNameLiteral,
                testCodeLiteral));

        public static Statement ReferenceEquals(
            string object1Literal,
            string object2Literal)
            => Assert(nameof(ReferenceEquals),
                typeArgs: null,
                object1Literal,
                object2Literal);

        public static Statement Same(
            string object1Literal,
            string object2Literal)
            => Assert(nameof(Same),
                typeArgs: null,
                object1Literal,
                object2Literal);

        public static Statement Single(
            string collectionLiteral,
            string arg2Literal,
            string typeLiteral = null)
            => Assert(nameof(Single),
                typeLiteral,
                collectionLiteral,
                arg2Literal);

        public static Statement StartsWith(
            string expectedEndStringLiteral,
            string actualStringLiteral,
            string comparisonTypeLiteral = null)
            => Assert(nameof(StartsWith),
                typeArgs: null,
                expectedEndStringLiteral,
                actualStringLiteral,
                comparisonTypeLiteral);

        public static Statement StrictEqual(
            string object1Literal,
            string object2Literal,
            string typeLiteral = null)
            => Assert(nameof(StrictEqual),
                typeLiteral,
                object1Literal,
                object2Literal);

        public static Statement Subset(
            string expectedLiteral,
            string actualLiteral,
            string typeLiteral = null)
            => Assert(nameof(Subset),
                typeLiteral,
                expectedLiteral,
                actualLiteral);

        public static Statement Superset(
            string expectedLiteral,
            string actualLiteral,
            string typeLiteral = null)
            => Assert(nameof(Superset),
                typeLiteral,
                expectedLiteral,
                actualLiteral);

        public static Statement Throws(
            string arg1Literal,
            string arg2Literal,
            string typeLiteral = null)
            => Assert(nameof(Throws),
                typeLiteral,
                arg1Literal,
                arg2Literal);

        public static Statement ThrowsAny(
            string arg1Literal,
            string arg2Literal,
            string typeLiteral = null)
            => Assert(nameof(ThrowsAny),
                typeLiteral,
                arg1Literal,
                arg2Literal);

        public static Statement ThrowsAnyAsync(
            string testCodeLiteral,
            string typeLiteral)
            => Await(Assert(nameof(ThrowsAnyAsync),
                typeLiteral,
                testCodeLiteral));

        public static Statement ThrowsAsync(
            string arg1Literal,
            string arg2Literal,
            string typeLiteral = null)
            => Await(Assert(nameof(ThrowsAsync),
                typeLiteral,
                arg1Literal,
                arg2Literal));

        public static Statement True(
            string conditionLiteral,
            string userMessageLiteral = null)
            => Assert(nameof(True),
                typeArgs: null,
                conditionLiteral,
                userMessageLiteral);

        private static Statement Await(Statement statement)
        {
            statement.Text.Value = $"await {statement.Text.Value}";
            return statement;
        }
    }
}
