using System.Threading.Tasks;
using Abp.Application.Services;
using EV.Sessions.Dto;

namespace EV.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
