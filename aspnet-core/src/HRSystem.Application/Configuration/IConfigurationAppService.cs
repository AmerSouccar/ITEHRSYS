using System.Threading.Tasks;
using HRSystem.Configuration.Dto;

namespace HRSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
