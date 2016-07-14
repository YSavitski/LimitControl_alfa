using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitControl_alfa
{
    public static class Connection
    {
        private static string strConn =
            string.Format(
                @"Data Source = ESAVITSKY; Initial Catalog = LimitsDB; Integrated Security = True; Pooling = true");

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(strConn);
            return connection;
        }
    }
}
