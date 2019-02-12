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
            _password = _userPassword;
        }
        public void CheckUserRights()
        {
            List<string> listOfRights = new List<string>();
            var _listOfRights = DataSet.RIGHT_TO_ROLE_VW.Where(x => x.role_name == DataSet.USER_DATA_VW.Single(y => y.user_login == Login).role_name);
            if (listOfRights.Count() != 0)
            {
                foreach (var Right in _listOfRights)
                {
                    listOfRights.Add(Right.right_name);
                }
            }
            else
            {
                throw new Exception("Not a valid user!");
            }
            UserRights = listOfRights;
        }
    }
}
