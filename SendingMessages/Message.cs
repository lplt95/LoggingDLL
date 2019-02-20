using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using LoggingDLL.Models;

namespace SendingMessages
{
    public class Message : UserModel
    {
        SmtpClient client = new SmtpClient()
        {
            EnableSsl = true,
            DeliveryFormat = SmtpDeliveryFormat.International,
            Credentials = new NetworkCredential("typicalUserName", "typicalPassword"),
            Host = "typicalHostAddress",
            Port = 000,
        };
        readonly MailMessage mailMessage;
        /// <summary>
        /// Create and send new email message. <br>
        /// In message text, you can separate new line using \n tag. <br>
        /// Remember! Values in this class are only testing values, sending email will not be successfull.
        /// </summary>
        /// <param name="_userName"></param>
        /// <param name="_messageText"></param>
        /// <param name="_messageSubject"></param>
        public Message(string _userName, string _messageText, string _messageSubject)
        {
            MailAddress toAddress = new MailAddress(DataSet.USERS_DATA.Single(x => x.user_login == _userName).user_email);
            mailMessage = new MailMessage(new MailAddress("typicalMailAddress", "System Contact"), toAddress)
            {
                Subject = _messageSubject,
                IsBodyHtml = true,
                SubjectEncoding = Encoding.Default,
                Body = _messageText.Replace("\n", "<br>") + "<br><br>This message was sent from automatic system. Do not replay.",
                BodyEncoding = Encoding.Default,
                Priority = MailPriority.High
            };
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
