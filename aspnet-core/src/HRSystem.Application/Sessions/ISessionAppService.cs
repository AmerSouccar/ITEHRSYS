using System.Threading.Tasks;
using Abp.Application.Services;
using HRSystem.Sessions.Dto;

namespace HRSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
