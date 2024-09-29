using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TestAutomapper.Configuration.Dto;

namespace TestAutomapper.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestAutomapperAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
