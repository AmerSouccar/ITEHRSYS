using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HRSystem.EntityFrameworkCore
{
    public static class HRSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HRSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HRSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
