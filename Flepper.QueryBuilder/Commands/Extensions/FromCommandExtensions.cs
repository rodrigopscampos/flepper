﻿namespace Flepper.QueryBuilder
{
    /// <summary>
    /// From Command extensions
    /// </summary>
    public static class FromCommandExtensions
    {
        /// <summary>
        /// Add Where to query
        /// </summary>
        /// <param name="fromCommand">From command instance</param>
        /// <param name="column">Column name</param>
        /// <returns></returns>
        public static IWhereFilter Where(this IFromCommand fromCommand, string column)
            => fromCommand.To<WhereFilter>().Where(column);

        /// <summary>
        /// Add Inner Join to query
        /// </summary>
        /// <param name="fromCommand">From command instance</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IJoin InnerJoin(this IFromCommand fromCommand, string table)
            => fromCommand.To<Join>().InnerJoin(table);

        /// <summary>
        /// Add Left Join to query
        /// </summary>
        /// <param name="fromCommand">From command instance</param>
        /// <param name="table">Table name</param>
        /// <returns></returns>
        public static IJoin LeftJoin(this IFromCommand fromCommand, string table)
            => fromCommand.To<Join>().LeftJoin(table);

        /// <summary>
        /// Add As to query
        /// </summary>
        /// <param name="fromCommand">From command instance</param>
        /// <param name="alias">Table alias</param>
        /// <returns></returns>
        public static IAliasOperator As(this IFromCommand fromCommand, string alias)
            => fromCommand.To<AliasOperator>().As(alias);

        /// <summary>
        /// OrderBy to query
        /// </summary>
        /// /// <param name="sortCommand">Sort command instance</param>
        /// <param name="column">Column</param>
        /// <param name="descending">Descending Order</param>
        /// <returns></returns>
        public static ISort OrderBy(this ISortCommand sortCommand, string column, bool descending = false)
            => sortCommand.To<Sort>().OrderBy(column, descending);

        /// <summary>
        /// OrderBy to query
        /// </summary>
        /// /// <param name="sortCommand">Sort command instance</param>
        /// <param name="tableAlias">Table Alias</param>
        /// <param name="column">Column Name</param>
        /// <param name="descending">Descending Order</param>
        /// <returns></returns>
        public static ISort OrderBy(this ISortCommand sortCommand, string tableAlias, string column, bool descending = false)
            => sortCommand.To<Sort>().OrderBy(tableAlias, column, descending);
       
    }
}