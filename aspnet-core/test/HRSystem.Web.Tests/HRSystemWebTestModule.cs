using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HRSystem.EntityFrameworkCore;
using HRSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace HRSystem.Web.Tests
{
    [DependsOn(
        typeof(HRSystemWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class HRSystemWebTestModule : AbpModule
    {
        public HRSystemWebTestModule(HRSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HRSystemWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(HRSystemWebMvcModule).Assembly);
        }
    }
}