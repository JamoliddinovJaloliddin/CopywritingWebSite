using CopywritingWebSite.Service.Interfaces.Common;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;

namespace CopywritingWebSite.Service.Services.Common
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration.GetSection("EmailSettings");
        }

        public async Task<int> SendAsync(string email)
        {

            Random random = new Random();

            var resault = random.Next(100000, 999999);

            var userEmail = new MimeMessage();

            userEmail.From.Add(MailboxAddress.Parse(_configuration["Email"]));
            userEmail.To.Add(MailboxAddress.Parse(email));
            userEmail.Subject = "VerificationCode";
            userEmail.Body = new TextPart(TextFormat.Html) { Text = $"{resault}" };

            var smtp = new SmtpClient();
            await smtp.ConnectAsync(_configuration["Host"], 587, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_configuration["Email"], _configuration["Password"]);
            await smtp.SendAsync(userEmail);
            await smtp.DisconnectAsync(true);
            return resault;
        }
    }
}
