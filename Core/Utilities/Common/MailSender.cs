using System.Net;
using System.Net.Mail;

namespace Core.Utilities.Common
{
    public static class MailSender
    {
        public static void Send(string to, string title,string message)
        {
            MailMessage msg = new MailMessage("teknoceppp1@gmail.com", to);
            msg.Subject = title;
            msg.Body = message;
            msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = 
                new NetworkCredential("teknoceppp1@gmail.com", "ceptekno321");
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            smtp.Send(msg);
        }
    }
}
