﻿using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.RiskProfileServices
{
    public class RiskProfileService :
        CrudAppService<RiskProfile, RiskProfileDto, Guid,
            PagedAndSortedResultRequestDto,
            CreateRiskProfileDto, UpdateRiskProfileDto>,
        IRiskProfileService
    {
        public RiskProfileService(IRepository<RiskProfile, Guid> repository) : base(repository)
        {
        }
    }
}
