using Dapper;
using JulieLibrary.DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Text;

namespace JulieLibrary
{
    class Helper
    {
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public static void DapperExecute(string query)
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                connection.Execute(query);
            }
        }

        public static List<Product> DapperQuery(string query)
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                return connection.Query<Product>(query).AsList();
            }
        }
    }
}
