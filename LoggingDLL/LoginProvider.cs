using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingDLL.Models;

namespace LoggingDLL
{
    public class LoginProvider
    {
        User LoggedUser;
        protected INZYNIERKA0001 DataSet = new INZYNIERKA0001();
        public LoginProvider(string _userLogin, string _userPassword)
        {
            string _hashedPassword = Crypto.GetHash(_userPassword);
            if (SignIn(_userLogin, _hashedPassword))
            {
                LoggedUser = new User(_userLogin, _hashedPassword);
                LoggedUser.CheckUserRights();
            }
            else
            {
                throw new Exception("Invalid login or password!");
            }
        }
        public User GetLoggedUser { get { return LoggedUser; } }
        public bool SignIn(string _userLogin, string _userPassword)
        {
            if (Crypto.VerifyHash(DataSet.USER_DATA_VW.Single(x => x.user_login == _userLogin).user_password, _userPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
