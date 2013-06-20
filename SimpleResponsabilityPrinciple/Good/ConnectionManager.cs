using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SingleResponsabilityPrinciple.Good
{
    public static class ConnectionManager
    {
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            if (connection == null)
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            return connection;
        }

        public static void OpenConnection()
        {
            if (connection == null)
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            connection.Open();
        }

        public static void CloseConnection()
        {
            if (connection == null)
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);

            connection.Close();
        }
    }
}
