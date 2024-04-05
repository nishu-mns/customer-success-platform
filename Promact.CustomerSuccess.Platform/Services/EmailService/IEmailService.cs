using Promact.CustomerSuccess.Platform.Services.Dtos;
using Volo.Abp.DependencyInjection;

namespace Promact.CustomerSuccess.Platform.Services.EmailService
{
    public interface IEmailService
    {
        Task SendEmailAsync(EmailDto request);
    }
}
