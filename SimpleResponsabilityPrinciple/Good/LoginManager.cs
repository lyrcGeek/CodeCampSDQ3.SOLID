
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SingleResponsabilityPrinciple.Good
{
    public class LoginManager
    {
        private Logger logger;

        public LoginManager()
        {
            logger = new Logger();
        }

        public bool AuthenticateUser(User user)
        {
            var command = CreateAuthenticationCommandFromUser(user);

            try
            {
                ConnectionManager.OpenConnection();

                string userName = command.ExecuteScalar().ToString();
                
                return IsValidUser(userName);
            }
            catch (Exception ex)
            {
                logger.WriteToLog(ex.Message);
                logger.SaveLog();
                return false;
            }
            finally
            {
                ConnectionManager.CloseConnection();
            }
        }

        private bool IsValidUser(string userName)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(userName))
            {
                result = true;
            }

            return result;
        }

        private SqlCommand CreateAuthenticationCommandFromUser(User user)
        {
            var command = GetCommand("uspAuthenticateUser", CommandType.StoredProcedure);
            
            var parameters = new SqlParameter[] 
            { 
                new SqlParameter("@UserName", SqlDbType.VarChar, 10){Value = user.UserName},
                new SqlParameter("@Password", SqlDbType.VarChar, 20){Value = user.Password},
            };

            command.Parameters.AddRange(parameters);

            return command;
        }

        private SqlCommand GetCommand(string commandText, CommandType commandType)
        {
            var command = ConnectionManager.GetConnection().CreateCommand();
            command.Connection = ConnectionManager.GetConnection();
            command.CommandText = commandText;
            command.CommandType = commandType;

            return command;
        }
    }
}
