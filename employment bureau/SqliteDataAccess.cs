using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employment_bureau
{
    public class SqliteDataAccess
    {
        private string v;

        public SqliteDataAccess(string v)
        {
            this.v = v;
        }

        private static string LoadConnectionString(string id ="Default") 
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=E:\politeh\2022 industrial practice\application\employment bureau\employment bureau\EB.db");
            con.Open();
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
