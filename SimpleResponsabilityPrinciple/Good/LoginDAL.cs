using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SingleResponsabilityPrinciple.Good
{
    public class LoginDAL
    {
        private Logger logger;

        public LoginDAL()
        {
            logger = new Logger();
        }

        public User Login(User user)
        {
            User result = null;

            try
            {
                //Create command for authentication user 
                var command = CreateAuthenticationCommandFromUser(user);
                
                //Open Connection to Server
                DbManager.OpenConnection();

                //Execute Connection
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    user.Name = reader.GetString(0);
                    result = user;
                }


                reader.Dispose();

                //Close Connection with server
                DbManager.CloseConnection();
            }
            catch (Exception ex)
            {
                logger.WriteToLog(ex.Message);
            }

            return result;
        }

        private IDbCommand CreateAuthenticationCommandFromUser(User user)
        {
            var command = DbManager.CreateCommand("uspLoginUser", CommandType.StoredProcedure);

            command.Parameters.Add(DbManager.GetParameter("UserName", user.UserName));
            command.Parameters.Add(DbManager.GetParameter("Password", user.Password));

            return command;
        }
    }
}
