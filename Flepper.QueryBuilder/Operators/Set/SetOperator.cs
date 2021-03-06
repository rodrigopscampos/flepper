﻿using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class SetOperator : BaseQueryBuilder, ISetOperator
    {
        public SetOperator(StringBuilder command, IDictionary<string, object> parameters) : base(command, parameters)
        {
        }

        public ISetOperator Set<T>(string column, T value)
        {
            var parametersCount = AddParameters(value);

            SetValue(column, $"@p{parametersCount}");
            return this;
        }

        private void SetValue(string column, object value)
        {
            Command.AppendFormat(Command.ToString().Contains("SET")
                ? ",[{0}] = {1} "
                : "SET [{0}] = {1} ", column, value);
        }
    }
}