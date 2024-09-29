using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TestAutomapper.Controllers
{
    public abstract class TestAutomapperControllerBase: AbpController
    {
        protected TestAutomapperControllerBase()
        {
            LocalizationSourceName = TestAutomapperConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
