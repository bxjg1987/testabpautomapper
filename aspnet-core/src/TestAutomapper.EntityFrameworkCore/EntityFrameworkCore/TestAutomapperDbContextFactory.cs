using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TestAutomapper.Configuration;
using TestAutomapper.Web;

namespace TestAutomapper.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TestAutomapperDbContextFactory : IDesignTimeDbContextFactory<TestAutomapperDbContext>
    {
        public TestAutomapperDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TestAutomapperDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TestAutomapperDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TestAutomapperConsts.ConnectionStringName));

            return new TestAutomapperDbContext(builder.Options);
        }
    }
}
