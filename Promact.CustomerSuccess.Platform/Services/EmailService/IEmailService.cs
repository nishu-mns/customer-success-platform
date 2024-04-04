using Volo.Abp.DependencyInjection;

namespace Promact.CustomerSuccess.Platform.Services.EmailService
{
    public interface IEmailService : ITransientDependency
    {
        Task SendEmailAsync(string to, string subject, string body);
    }
}
