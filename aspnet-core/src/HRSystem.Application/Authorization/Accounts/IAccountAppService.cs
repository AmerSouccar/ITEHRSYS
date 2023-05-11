using System.Threading.Tasks;
using Abp.Application.Services;
using HRSystem.Authorization.Accounts.Dto;

namespace HRSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
