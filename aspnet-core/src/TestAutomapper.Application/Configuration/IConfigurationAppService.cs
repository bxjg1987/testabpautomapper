using System.Threading.Tasks;
using TestAutomapper.Configuration.Dto;

namespace TestAutomapper.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
