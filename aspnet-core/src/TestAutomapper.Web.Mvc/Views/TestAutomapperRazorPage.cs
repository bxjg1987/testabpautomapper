using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace TestAutomapper.Web.Views
{
    public abstract class TestAutomapperRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TestAutomapperRazorPage()
        {
            LocalizationSourceName = TestAutomapperConsts.LocalizationSourceName;
        }
    }
}
