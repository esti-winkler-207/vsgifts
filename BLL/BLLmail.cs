using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class BLLmail
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
        //public static List<DTO.parents> getByPwdAndId(string pwd_group, string id_group)
        //{
        //    return DAL.DALparents.getByIdandPwd(pwd_group, id_group);

        //}
        public static void sendForAll()
        {

        }

        public static void SendMail(string to, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("ganchacham@gmail.com");
                mail.To.Add(to);
                mail.Subject = "BabySafe";
                mail.Body = body;
                mail.IsBodyHtml = true;
                // string htmlBody = "create html page";
                // mail.Body = htmlBody;


                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ganchacham@gmail.com", "M123H123");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("mail Send");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("mail !!!!!!!!!!!!!!!!!!Send");
            }
        }

    }
}
