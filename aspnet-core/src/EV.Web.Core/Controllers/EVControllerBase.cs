using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EV.Controllers
{
    public abstract class EVControllerBase: AbpController
    {
        protected EVControllerBase()
        {
            LocalizationSourceName = EVConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
