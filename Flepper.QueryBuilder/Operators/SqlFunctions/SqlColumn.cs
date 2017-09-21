using System;
using System.Runtime.CompilerServices;
using Flepper.QueryBuilder.Utils.Extensions;
using static System.String;

namespace Flepper.QueryBuilder.Operators.SqlFunctions
{
    /// <summary>
    /// Base function class used to improve implicit conversion
    /// </summary>
    public class SqlColumn
    {
        private const string ALIAS = " AS ";
        private static readonly string[] AliasSplitter = { ALIAS, " as " };

        /// <summary>
        /// the column name or sql function.
        /// </summary>
        protected string Column { get; }

        /// <summary>
        /// the column alias
        /// </summary>
        protected string Alias { get; }

        private readonly string _columnStatement;

        internal SqlColumn(string column, string alias = null)
        {
            if (IsNullOrWhiteSpace(column)) throw new ArgumentNullException($"{nameof(column)} cannot be null or empty");
            if (ContainsAlias(column))
                (Column, Alias) = column.Split(AliasSplitter, StringSplitOptions.RemoveEmptyEntries);
            else
            {
                Column = column;
                Alias = alias;
            }

            _columnStatement = $"[{Column}]";
            if (IsNullOrWhiteSpace(Alias) == false) _columnStatement = $"{_columnStatement} AS {Alias}";
        }

        /// <summary>
        /// Implicit convertion string to SqlBaseFunction
        /// </summary>
        /// <param name="column">a column name</param>
        public static implicit operator SqlColumn(string column)
            => new SqlColumn(column);

        /// <summary>
        /// ovveride ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString() => _columnStatement;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool ContainsAlias(string source)
            => source.IndexOf(ALIAS, StringComparison.OrdinalIgnoreCase) > 0;

    }
}