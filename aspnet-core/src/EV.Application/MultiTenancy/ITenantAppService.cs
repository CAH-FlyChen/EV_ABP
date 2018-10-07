using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EV.MultiTenancy.Dto;

namespace EV.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
