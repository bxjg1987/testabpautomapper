using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestAutomapper.Configuration;

namespace TestAutomapper.Web.Host.Startup
{
    [DependsOn(
       typeof(TestAutomapperWebCoreModule))]
    public class TestAutomapperWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TestAutomapperWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestAutomapperWebHostModule).GetAssembly());
        }
    }
}
