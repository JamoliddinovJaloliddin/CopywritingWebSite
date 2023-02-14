using CopywritingWebSite.Service.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;

namespace CopywritingWebSite.Service.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            this._configuration = configuration.GetSection("EmailSettings");
        }

        public async Task<bool> SendAsync(string email)
        {
            var userEmail = new MimeMessage();

            userEmail.From.Add(MailboxAddress.Parse(_configuration["Email"]));
            userEmail.To.Add(MailboxAddress.Parse(email));
            userEmail.Subject = "";
            userEmail.Body = new TextPart(TextFormat.Html) { Text = "" };

            var smtp = new SmtpClient();
            await smtp.ConnectAsync(_configuration["Host"], 587, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_configuration["Email"], _configuration["Password"]);
            await smtp.SendAsync(userEmail);
            await smtp.DisconnectAsync(true);
            return true;

        }
    }
}
