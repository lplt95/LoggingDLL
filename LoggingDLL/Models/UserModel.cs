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
        protected List<string> _userRights;

        public string Login { get; }
        public string Password { get; }
        public string UserRights { get; }
    }
}
