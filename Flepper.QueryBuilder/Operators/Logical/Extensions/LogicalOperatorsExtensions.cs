﻿
namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Logical Operators Extensions
    /// </summary>
    public static class LogicalOperatorsExtensions
    {
        /// <summary>
        /// Add Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators EqualTo(this ILogicalOperators logicalOperators, string value)
            => logicalOperators is IComparisonOperators command ? command.EqualTo(value) : null;

        /// <summary>
        /// Add Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators EqualTo(this ILogicalOperators logicalOperators, int value)
            => logicalOperators is IComparisonOperators command ? command.EqualTo(value) : null;

        /// <summary>
        /// Add Greater Than Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThan(this ILogicalOperators logicalOperators, int value)
            => logicalOperators is IComparisonOperators command ? command.GreaterThan(value) : null;

        /// <summary>
        /// Add Less Than Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators LessThan(this ILogicalOperators logicalOperators, int value)
            => logicalOperators is IComparisonOperators command ? command.LessThan(value) : null;

        /// <summary>
        /// Add Greater Than Or Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators GreaterThanOrEqualTo(this ILogicalOperators logicalOperators, int value)
            => logicalOperators is IComparisonOperators command ? command.GreaterThanOrEqualTo(value) : null;

        /// <summary>
        /// Add Less Than Or Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators LessThanOrEqualTo(this ILogicalOperators logicalOperators, int value)
            => logicalOperators is IComparisonOperators command ? command.LessThanOrEqualTo(value) : null;

        /// <summary>
        /// Add Not Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators NotEqualTo(this ILogicalOperators logicalOperators, int value)
            => logicalOperators is IComparisonOperators command ? command.NotEqualTo(value) : null;

        /// <summary>
        /// Add Not Equal Operator to query
        /// </summary>
        /// <param name="logicalOperators">Logical Operators instance</param>
        /// <param name="value">Value</param>
        /// <returns></returns>
        public static IComparisonOperators NotEqualTo(this ILogicalOperators logicalOperators, string value)
            => logicalOperators is IComparisonOperators command ? command.NotEqualTo(value) : null;
    }
}
