using Abp.AspNetCore.Mvc.ViewComponents;

namespace TestAutomapper.Web.Views
{
    public abstract class TestAutomapperViewComponent : AbpViewComponent
    {
        protected TestAutomapperViewComponent()
        {
            LocalizationSourceName = TestAutomapperConsts.LocalizationSourceName;
        }
    }
}
