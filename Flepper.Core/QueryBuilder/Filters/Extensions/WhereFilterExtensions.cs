﻿using Flepper.Core.QueryBuilder.Filters.Interfaces;
using Flepper.Core.QueryBuilder.Operators.Comparison;
using Flepper.Core.QueryBuilder.Operators.Comparison.Interfaces;

namespace Flepper.Core.QueryBuilder.Filters.Extensions
{
    public static class WhereFilterExtensions
    {
        public static IComparisonOperators Equal(this IWhereFilter whereFilter, string value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.Equal(value);

            return equalCompareOperator;
        }

        public static IComparisonOperators Equal(this IWhereFilter whereFilter, int value)
        {
            var equalCompareOperator = ComparisonOperators.Create();

            equalCompareOperator.Equal(value);

            return equalCompareOperator;
        }
    }
}
