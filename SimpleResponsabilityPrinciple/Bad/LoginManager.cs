using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace SingleResponsabilityPrinciple.Bad
{
    public class LoginManager
    {
        public bool AutenticateUser(User user)
        {
            var result = false;

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = @"SELECT UserName FROM Users WHERE UserName = '" + user.UserName + "'" + 
                                    "AND Password = '" + user.UserName + "'";

            try
            {
                connection.Open();
                string name = command.ExecuteScalar().ToString();
                if (!string.IsNullOrEmpty(name))
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                StringWriter logger = new StringWriter();
                logger.WriteLine(ex.Message);
            }

            return result;
        }
    }
}
