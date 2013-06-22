
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
        private LoginDAL loginDAL;

        public LoginManager()
        {
            loginDAL = new LoginDAL();
        }

        public bool AuthenticateUser(User user)
        {
            bool result = true;

            var authenticatedUser = loginDAL.Login(user);

            if (authenticatedUser == null)
                result = false;

            return result;
        }
    }
}
