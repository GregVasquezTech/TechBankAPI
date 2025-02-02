using System.Net;
using System.Net.Mail;
using TechBankAPI.Services.Interfaces;

namespace TechBankAPI.Services.Implementations
{
    public class PasswordResetService : IPasswordResetService
    {
        private readonly string _smtpServer = "smtp.example.com";
        private readonly int _smtpPort = 587;
        private readonly string _smtpUser = "tech-bank@api.com";
        private readonly string _smtpPassword = "password";
        public Task ResetPassword()
        {
            throw new NotImplementedException();
        }

        public async Task SendPasswordResetEmail(string toEmail)
        {
            using (var client = new SmtpClient(_smtpServer, _smtpPort))
            {
                client.Credentials = new NetworkCredential(_smtpUser, _smtpPassword);
                client.EnableSsl = true;

                var emailMessage = new MailMessage
                {
                    From = new MailAddress(_smtpUser),
                    Subject = "Request to reset password",
                    Body = "Click here to reset password",
                    IsBodyHtml = true
                };

                emailMessage.To.Add(toEmail);

                try
                {
                    await client.SendMailAsync(emailMessage);
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("An error occurred while sending the reset password email.", ex);
                }
            }

        }
    }
}
