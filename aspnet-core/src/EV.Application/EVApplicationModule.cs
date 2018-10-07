using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EV.Authorization;

namespace EV
{
    [DependsOn(
        typeof(EVCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EVApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EVAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EVApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
