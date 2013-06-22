using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace SingleResponsabilityPrinciple.Good
{
    public static class DbManager
    {
        private static IDbConnection connection;
        private static string dbProvider = ConfigurationManager.AppSettings["DbProvider"];

        public static IDbConnection GetConnection()
        {
            CreateConnection();            
            return connection;
        }

        private static void CreateConnection()
        {
            if (connection == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                
                switch (dbProvider)
                {
                    case "Access":
                        connection = new OleDbConnection(connectionString);
                        break;
                    case "SqlServer":
                        connection = new SqlConnection(connectionString);
                        break;
                    default:
                        throw new InvalidOperationException("Provider not Implemented");
                  
                } 
            }
        }

        public static void OpenConnection()
        {
            CreateConnection();
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        public static void CloseConnection()
        {
            CreateConnection();

            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public static IDbCommand CreateCommand(string commandText, CommandType commandType)
        {
            var command = DbManager.GetConnection().CreateCommand();
            command.Connection = DbManager.GetConnection();
            command.CommandText = commandText;
            command.CommandType = commandType;

            return command;
        }

        public static IDbDataParameter GetParameter(string name, object value)
        {
            IDbDataParameter parameter = null;

            switch (dbProvider)
            {
                case "Access":
                    parameter = new OleDbParameter(name, value);
                    break;
                case "SqlServer":
                    parameter = new SqlParameter(name, value);
                    break;
                default:
                    throw new InvalidOperationException("Provider not Implemented");

            }

            return parameter;
        }

    }
}
