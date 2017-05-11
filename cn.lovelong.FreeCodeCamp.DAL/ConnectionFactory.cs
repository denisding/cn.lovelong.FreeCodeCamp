using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.lovelong.FreeCodeCamp.DAL
{
    public class ConnectionFactory
    {
        private static readonly string ConnString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

        public static IDbConnection CreateConnection()
        {
            IDbConnection conn = new SqlConnection(ConnString);
            conn.Open();
            return conn;
        }
    }
}
