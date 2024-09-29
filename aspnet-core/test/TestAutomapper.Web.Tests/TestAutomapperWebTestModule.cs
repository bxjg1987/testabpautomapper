using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestAutomapper.EntityFrameworkCore;
using TestAutomapper.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TestAutomapper.Web.Tests
{
    [DependsOn(
        typeof(TestAutomapperWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TestAutomapperWebTestModule : AbpModule
    {
        public TestAutomapperWebTestModule(TestAutomapperEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestAutomapperWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TestAutomapperWebMvcModule).Assembly);
        }
    }
}