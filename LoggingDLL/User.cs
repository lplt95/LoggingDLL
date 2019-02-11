using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LoggingDLL.Models;

namespace LoggingDLL
{
    public class User : UserModel
    {
        /// <summary>
        /// Creating new instance of User using login and password
        /// </summary>
        /// <param name="_userLogin">Set username</param>
        /// <param name="_userPassword">Set password</param>
        public User(string _userLogin, string _userPassword)
        {
            _login = _userLogin;
            //haszujemy hasło
            _password = Crypto.GetHash(_userPassword);
            if(SignIn())
            {
                
            }
        }
        public bool SignIn()
        {
            List<string> listOfRights = new List<string>();
            INZYNIERKA0001 DataSet = new INZYNIERKA0001();
            if (Crypto.VerifyHash(DataSet.USER_DATA_VW.Single(x => x.user_login == Login).user_password, _password))
            {
                var _listOfRights = DataSet.RIGHT_TO_ROLE_VW.Where(x => x.role_name == DataSet.USER_DATA_VW.Single(y => y.user_login == Login).role_name);
                foreach (var Right in _listOfRights)
                {
                    listOfRights.Add(Right.right_name);
                }
                _userRights = listOfRights;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
