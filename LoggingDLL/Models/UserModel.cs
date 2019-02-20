using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingDLL.Models
{
    public class UserModel
    {
        protected string _login;
        protected string _password;
        protected string _emailAddress;
        protected List<string> _userRights;
        protected INZYNIERKA0001 DataSet = new INZYNIERKA0001();

        public string Login { get { return _login; } }

        public string Password { get { return _password; } }
        public List<string> UserRights
        {
            get
            {
                return _userRights;
            }
            set
            {
                if (UserRights.Count() != 0)
                {
                    foreach (var Right in UserRights)
                    {
                        _userRights.Add(Right);
                    }
                }
                else
                {
                    _userRights = null;
                }
            }
        }
    }
}
