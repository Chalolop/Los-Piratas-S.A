using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PiratasCostaRica.BDConection
{
    class Myconection
    {
        private string sqlConnection = "Data Source=LENOVO-PC;Initial Catalog=TSQL2012;Integrated Security=true";
        //private string sqlConnection =
        //                            "server=LENOVO-PC;" +
        //                               "Trusted_Connection=yes;" +
        //                               "Integrated Security=true" +
        //                               "database=TSQL2012; " +
        //                               "connection timeout=30";

        public string SQLConnection
        {
            get
            {
                return sqlConnection;
            }
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection(sqlConnection);
            return connection;
        }

        public SqlCommand CreateCommand(SqlConnection cnn)
        {
            SqlCommand sqlcommand = new SqlCommand(sqlConnection, cnn);
            return sqlcommand;
        }
    }

}
