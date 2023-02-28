using System.Net;
using System.Net.Mail;

namespace MyOnlineShop.Models
{
    public class SendGmail
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            using (var Client = new SmtpClient())
            {
                var Credential = new NetworkCredential
                {
                    UserName = "chromreyhan@gmail.com",
                    Password = "13781377"
                };
                Client.Credentials = Credential;
                Client.Host = "smtp.gmail.com";
                Client.Port = 587;
                Client.EnableSsl = true;
                using (var emailMessage = new MailMessage())
                {
                    emailMessage.To.Add(new MailAddress(email));
                    emailMessage.From = new MailAddress("EmailAddress");
                    emailMessage.Subject = subject;
                    emailMessage.IsBodyHtml = true;
                    emailMessage.Body = message;

                    Client.Send(emailMessage);
                };
                await Task.CompletedTask;
            }
        }
    }
}
