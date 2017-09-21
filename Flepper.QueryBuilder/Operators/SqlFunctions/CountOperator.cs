using System;
using static System.String;

namespace Flepper.QueryBuilder.Operators.SqlFunctions
{
    /// <summary>
    /// Count Operator class
    /// </summary>
    public sealed class CountOperator : SqlColumn
    {
        private readonly string _columnFunctionStatement;

        /// <summary>
        /// constructor to Count class
        /// </summary>
        /// <param name="column">column name</param>
        /// <param name="alias">alias to column. All alias start with func_</param>
        public CountOperator(string column, string alias)
            : base(column, $"func_{alias}")
        {
            if (IsNullOrWhiteSpace(column) || IsNullOrWhiteSpace(alias)) throw new ArgumentNullException($"{nameof(column)} and {nameof(alias)} cannot be null or empty");

            _columnFunctionStatement = Column;
            if (IsNullOrWhiteSpace(Alias) == false) _columnFunctionStatement = $"COUNT([{_columnFunctionStatement}]) AS {Alias}";

        }

        private CountOperator(string column) : base(column)
        {

        }

        /// <summary>
        /// implicit operator to CountOperator
        /// </summary>
        /// <param name="column">column name</param>
        public static implicit operator CountOperator(string column)
            => new CountOperator(column);

        /// <summary>
        /// Overwrite ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            => _columnFunctionStatement;
    }
}