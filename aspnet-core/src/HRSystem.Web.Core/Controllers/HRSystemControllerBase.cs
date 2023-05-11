using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HRSystem.Controllers
{
    public abstract class HRSystemControllerBase: AbpController
    {
        protected HRSystemControllerBase()
        {
            LocalizationSourceName = HRSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
