using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using LoggingDLL.Models;
using StringHelpers;

namespace SendingMessages
{
    //Only for testing, client will be enter in constructor. 
    public class Message : UserModel
    {
        //Warning! Client is not fully configurated! Message will be not sent!
        //You can delete this warning when you enter correct credentials, host name and port.
        SmtpClient client = new SmtpClient()
        /*{
            EnableSsl = true,
            DeliveryFormat = SmtpDeliveryFormat.International,
            Credentials = new NetworkCredential("typicalUserName", "typicalPassword"),
            Host = "typicalHostAddress",
            Port = 000,
        }*/;
        StringHelper helper = new StringHelper();
        readonly MailMessage mailMessage;
        private Message(string _userName, string _messageText, string _messageSubject)
        {
            MailAddress toAddress = new MailAddress(DataSet.USERS_DATA.Single(x => x.user_login == _userName).user_email);
            mailMessage = new MailMessage(new MailAddress("typicalMailAddress", "System Contact"), toAddress)
            {
                Subject = _messageSubject,
                IsBodyHtml = true,
                SubjectEncoding = Encoding.Default,
                Body = helper.ReplaceSth(_messageText, "\n", "<br>") + "<br><br>This message was sent from automatic system. Do not replay.",
                BodyEncoding = Encoding.Default,
                Priority = MailPriority.High
            };
            SendEmail();
        }
        /// <summary>
        /// Create and send new email message. <br>
        /// In message text, you can separate new line using \n tag. <br>
        /// Remember! Values in this class are only testing values, sending email will not be successfull.
        /// </summary>
        /// <param name="_userName"></param>
        /// <param name="_messageText"></param>
        /// <param name="_messageSubject"></param>
        public Message(string _userName, string _messageText, string _messageSubject, SmtpClient SMTP_client)
        {
            MailAddress toAddress = new MailAddress(DataSet.USERS_DATA.Single(x => x.user_login == _userName).user_email);
            mailMessage = new MailMessage(new MailAddress("typicalMailAddress", "System Contact"), toAddress)
            {
                Subject = _messageSubject,
                IsBodyHtml = true,
                SubjectEncoding = Encoding.Default,
                Body = helper.ReplaceSth(_messageText, "\n", "<br>") + "<br><br>This message was sent from automatic system. Do not replay.",
                BodyEncoding = Encoding.Default,
                Priority = MailPriority.High
            };
            client = SMTP_client;
            SendEmail();
        }
        void SendEmail()
        {
            try
            {
                client.Send(mailMessage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
