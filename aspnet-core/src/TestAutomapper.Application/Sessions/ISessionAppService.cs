using System.Threading.Tasks;
using Abp.Application.Services;
using TestAutomapper.Sessions.Dto;

namespace TestAutomapper.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
