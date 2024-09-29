using Abp.Application.Services;
using TestAutomapper.MultiTenancy.Dto;

namespace TestAutomapper.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

