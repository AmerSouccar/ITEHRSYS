using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HRSystem.Configuration;

namespace HRSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(HRSystemWebCoreModule))]
    public class HRSystemWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HRSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HRSystemWebHostModule).GetAssembly());
        }
    }
}
