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
        System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
        int _userRole;
        /// <summary>
        /// Creating new instance of user with login and password. You have to enter email address here. In the future, user will enter more data. 
        /// </summary>
        /// <param name="_userLogin">Maximum 20 characters</param>
        /// <param name="_userPassword">Should contains one big letter, one numeric character and more than 8 characters.</param>
        /// <param name="_userEmail"></param>
        public CreateUser(string _userLogin, string _userPassword, string _userEmail)
        {
            _login = _userLogin;
            _password = Crypto.GetHash(_userPassword);
            _userRole = 1;
            _emailAddress = _userEmail;
            CreateUserAccount();
        }
        bool InsertUserData()
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
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        void SendMessage()
        {
            string _messageText = "Hello, \nWelcome to the world of books and films. \nYour account has been created and it's active now. \nEnjoy and have fun!";
            var MessageProvider = new SendingMessages.Message(_login, _messageText, "Create account", client);
        }
        void CreateUserAccount()
        {
            if (InsertUserData())
                SendMessage();
            else
                throw new Exception("Ups! Something went wrong while saving user data. Please check or contact with support.");
        }
    }
}
