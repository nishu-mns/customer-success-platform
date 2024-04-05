using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos;
using Promact.CustomerSuccess.Platform.Services.EmailService;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.AuditHistoryServices
{
    public class AuditHistoryService :
        CrudAppService<AuditHistory, 
            AuditHistoryDto, 
            Guid,
            PagedAndSortedResultRequestDto, 
            CreateAuditHistory, 
            UpdateAuditHistory>,
        IAuditHistoryService
    {
        private readonly IEmailService _emailService;
        public AuditHistoryService(IRepository<AuditHistory, Guid> repository, IEmailService emailService) : base(repository)
        {
            _emailService = emailService;
        }

        public override async Task<AuditHistoryDto> CreateAsync(CreateAuditHistory input)
        {
            var auditHistoryDto = await base.CreateAsync(input);

            var emailDto = new EmailDto
            {
                Subject = "Testing email service!",
                Body = "Testing email..." + input.ReviewedBy,
                Recipient = "nisha.makwana2423@gmail.com"
            };

            await _emailService.SendEmailAsync(emailDto);

            return auditHistoryDto;
        }
    }
}
