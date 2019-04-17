using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SendingMessages;
using LoggingDLL.Models;
using LoggingDLL;

namespace CreateNewUser
{
    class ChangeUser : UserModel
    {
        readonly User AdminUser, ChangingUser;
        readonly string _loggedUserLogin;

        public ChangeUser(User adminUser, User changingUser, string _loggedUser)
        {
            AdminUser = adminUser;
            ChangingUser = changingUser;
            _loggedUserLogin = _loggedUser;
        }
        public void ChangeRights(int _newRole)
        {
            if ((AdminUser.UserRights.Contains("CanChangeUserRights") && !ChangingUser.UserRights.Contains("IsSuperadmin")) || AdminUser.UserRights.Contains("IsSuperadmin"))
            {
                var changingUser = DataSet.USERS_DATA.Single(x => x.user_login == ChangingUser.Login);
                changingUser.role_id = _newRole;
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
        public void ChangePassword(string _newPassword)
        {
            if(AdminUser.UserRights.Contains("IsSuperadmin"))
            {
                var changingUser = DataSet.USERS_DATA.Single(x => x.user_login == ChangingUser.Login);
                changingUser.user_password = Crypto.GetHash(_newPassword);
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
        public void ResetPassword()
        {
            if(AdminUser.UserRights.Contains("CanResetPassword") || ChangingUser.Login == _loggedUserLogin)
            {
                string _newPassword = "Pass1234";
                var changingUser = DataSet.USERS_DATA.Single(x => x.user_login == ChangingUser.Login);
                changingUser.user_password = Crypto.GetHash(_newPassword);
                changingUser.need_password_change = true;
                string _messageText = "Your password was reseted. New password is: \n <center>" + _newPassword + "</center>\nThis was done by yourself or one of admins. \nIf you didn't request reseting password, you should contact with superadmin under this address: \nsuperadmincontact@app.com \n\nRemember! You should change your password with first login into application.";
                try
                {
                    DataSet.SaveChanges();
                    //Message infoMessage = new Message(changingUser.user_login, _messageText, "Password reset");
                }
                catch (Exception e)
                { 
                    throw e;
                }
            }
        }
    }
}
