using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HRSystem.Configuration.Dto;

namespace HRSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HRSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
