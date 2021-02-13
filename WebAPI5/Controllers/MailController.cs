using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;

namespace WebAPI5.Controllers
{
    [RoutePrefix("api/mail")]
    public class MailController : ApiController
    {
        private static void SendEmail(string contactAddress, string subject, string body)
        {
            
            string FromMail = "giftgroups456@gmail.com";
            string emailTo = contactAddress;
            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(FromMail, "giftgroups456@gmail.com");
            mail.To.Add(emailTo);
            mail.Subject = subject;
            mail.Body = body;

            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential("giftgroups456@gmail.com", "presentteam");
            SmtpServer.EnableSsl = true;
            try
            {
                SmtpServer.Send(mail);
            }
            catch (Exception)
            {


            }
        }
        [HttpPost]
        [Route("sendemail")]
        public IHttpActionResult sendemail(DTO.mail m)
        {
            SendEmail(m.contactadress, m.subject, m.body);
            return Ok("sucsessfull!");
        }

    }
}
