﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeHelper.DataBaseHelper.DbSchema.DbSchemaProvider;

namespace CodeHelper.DataBaseHelper.DbSchema.Access
{
    public class AccessSchemaProvider : BaseDbSchemaProvider
    {
        public override ColumnSchema[] GetTableColumns(string connectionString, TableSchema table)
        {
            throw new NotImplementedException();
        }

        public override TableSchema[] GetTables(string connectionString, DatabaseSchema database)
        {
            //Util.AccessHelper.ExecuteSql(connectionString,
            throw new NotImplementedException();
        }

        public override TableSchema GetTable(string connectionString, string name)
        {
            throw new NotImplementedException();
        }
    }
}
