using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingDLL.Models;
using LoggingDLL;

namespace CreateNewUser
{
    class ChangeUser : UserModel
    {
        readonly User AdminUser, ChangingUser;

        public ChangeUser(User adminUser, User changingUser)
        {
            AdminUser = adminUser;
            ChangingUser = changingUser;
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
            if(AdminUser.UserRights.Contains("CanResetPassword"))
            {
                string _newPassword = "Pass1234";
                var changingUser = DataSet.USERS_DATA.Single(x => x.user_login == ChangingUser.Login);
                changingUser.user_password = Crypto.GetHash(_newPassword);
                //changingUser.need_pass_change = true;  --do przyszłego wykorzystania
                try
                {
                    DataSet.SaveChanges();
                    //SendMessage("ResetPassword", _newPassword);  --do przyszłego wykorzystania
                }
                catch (Exception e)
                { 
                    throw e;
                }
            }
        }
    }
}
