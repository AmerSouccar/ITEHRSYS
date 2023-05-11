using Abp.Application.Services;
using HRSystem.MultiTenancy.Dto;

namespace HRSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

