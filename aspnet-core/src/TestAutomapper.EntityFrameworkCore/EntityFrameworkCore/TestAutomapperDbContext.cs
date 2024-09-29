using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TestAutomapper.Authorization.Roles;
using TestAutomapper.Authorization.Users;
using TestAutomapper.MultiTenancy;

namespace TestAutomapper.EntityFrameworkCore
{
    public class TestAutomapperDbContext : AbpZeroDbContext<Tenant, Role, User, TestAutomapperDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TestAutomapperDbContext(DbContextOptions<TestAutomapperDbContext> options)
            : base(options)
        {
        }
    }
}
