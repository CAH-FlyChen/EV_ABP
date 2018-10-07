using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EV.Configuration.Dto;

namespace EV.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EVAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
