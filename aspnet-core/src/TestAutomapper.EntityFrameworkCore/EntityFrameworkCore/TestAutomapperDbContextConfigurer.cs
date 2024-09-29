using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TestAutomapper.EntityFrameworkCore
{
    public static class TestAutomapperDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TestAutomapperDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TestAutomapperDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
