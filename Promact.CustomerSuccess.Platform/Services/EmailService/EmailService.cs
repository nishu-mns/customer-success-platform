using Volo.Abp.DependencyInjection;
using System.Threading.Tasks;
using Volo.Abp.Emailing;
using MimeKit;
using MailKit.Net.Smtp;

namespace Promact.CustomerSuccess.Platform.Services.EmailService
{
    public class EmailService : IEmailService, ITransientDependency
    {
        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Nisha Makwana", "nisha.makwana2423@gmail.com"));
            message.To.Add(new MailboxAddress("", to)); // You can add multiple recipients if needed
            message.Subject = subject;

            message.Body = new TextPart("plain")
            {
                Text = body
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                await client.AuthenticateAsync("nisha.makwana2423@gmail.com", "vxattbwliievgkef");
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}
