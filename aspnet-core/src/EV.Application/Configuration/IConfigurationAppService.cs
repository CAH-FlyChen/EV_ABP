using System.Threading.Tasks;
using EV.Configuration.Dto;

namespace EV.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
