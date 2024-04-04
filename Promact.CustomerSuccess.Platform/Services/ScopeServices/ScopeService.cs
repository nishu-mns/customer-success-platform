﻿using Promact.CustomerSuccess.Platform.Entities;
using Promact.CustomerSuccess.Platform.Services.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Promact.CustomerSuccess.Platform.Services.ScopeServices
{
    public class ScopeService : 
        CrudAppService<Scope, 
            ScopeDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateScopeDto, 
            UpdateScopeDto>, 
        IScopeService
    {
        public ScopeService(IRepository<Scope, Guid> repository) : base(repository)
        {
        }
    }
}
