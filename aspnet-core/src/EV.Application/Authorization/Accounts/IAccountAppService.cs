using System.Threading.Tasks;
using Abp.Application.Services;
using EV.Authorization.Accounts.Dto;

namespace EV.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
