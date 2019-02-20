using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LoggingDLL;
using LoggingDLL.Models;

namespace CreateNewUser
{
    public class CreateUser : UserModel
    {
        int _userRole;
        
        public CreateUser(string _userLogin, string _userPassword, string _userEmail)
        {
            _login = _userLogin;
            _password = Crypto.GetHash(_userPassword);
            _userRole = 1;
            _emailAddress = _userEmail;
            InsertUserData();
        }
        void InsertUserData()
        {
            USERS_DATA NewUser = new USERS_DATA
            {
                user_password = _password,
                user_login = _login,
                role_id = _userRole,
                need_password_change = false,
                user_email = _emailAddress
            };
            DataSet.USERS_DATA.Add(NewUser);
            try
            {
                 DataSet.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
