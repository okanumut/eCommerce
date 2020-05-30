using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Entity
{
    public class DbConnections
    {
    }

    public class DbType
    {
        public static string MSSQL()
        {
            return "MSSQL";
        }
        public static string Mongo()
        {
            return "Mongo";
        }
    }
}
