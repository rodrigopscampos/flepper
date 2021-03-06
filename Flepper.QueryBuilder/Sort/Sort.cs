﻿using Flepper.QueryBuilder.Base;
using System.Collections.Generic;
using System.Text;

namespace Flepper.QueryBuilder
{
    internal class Sort : BaseQueryBuilder, ISort, ISortThen
    {
        public Sort(StringBuilder command, IDictionary<string, object> parameters) : base(command, parameters)
        {
        }

        public ISortThen OrderBy(string column)
        {
            Command.AppendFormat("ORDER BY [{0}]", column);
            return this;
        }

        public ISortThen OrderBy(string tableAlias, string column)
        {
            Command.AppendFormat("ORDER BY [{0}].[{1}]", tableAlias, column);
            return this;
        }

        public ISortThen OrderByDescending(string column)
        {
            Command.AppendFormat("ORDER BY [{0}] DESC", column);
            return this;
        }

        public ISortThen OrderByDescending(string tableAlias, string column)
        {
            Command.AppendFormat("ORDER BY [{0}].[{1}] DESC", tableAlias, column);
            return this;
        }

        public ISortThen ThenBy(string column)
        {
            Command.AppendFormat(", [{0}]", column);
            return this;
        }

        public ISortThen ThenBy(string tableAlias, string column)
        {
            Command.AppendFormat(", [{0}].[{1}]", tableAlias, column);
            return this;
        }

        public ISortThen ThenByDescending(string column)
        {
            Command.AppendFormat(", [{0}] DESC", column);
            return this;
        }

        public ISortThen ThenByDescending(string tableAlias, string column)
        {
            Command.AppendFormat(", [{0}].[{1}] DESC", tableAlias, column);
            return this;
        }
    }
}
