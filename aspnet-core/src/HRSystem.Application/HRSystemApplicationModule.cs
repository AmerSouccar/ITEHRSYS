using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HRSystem.Authorization;

namespace HRSystem
{
    [DependsOn(
        typeof(HRSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HRSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HRSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HRSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
