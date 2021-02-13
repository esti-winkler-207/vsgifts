using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;

namespace WebAPI5.Controllers
{
    public class MailController : ApiController
    {
        private static void SendEmail(string contactAddress, string subject, string body)
        {
            contactAddress = "5710490@gmail.com";
            subject = "hello!";
            body = "first mail";

            string FromMail = "estiwinkler207@gmail.com";
            string emailTo = contactAddress;
            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(FromMail, "estiwinkler207@gmail.com");
            mail.To.Add(emailTo);
            mail.Subject = subject;
            mail.Body = body;

            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential("estiwinkler207@gmail.com", "207347634");
            SmtpServer.EnableSsl = true;
            try
            {
                SmtpServer.Send(mail);
            }
            catch (Exception)
            {


            }
        }

    }
}
