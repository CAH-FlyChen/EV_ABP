using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EV.EntityFrameworkCore
{
    public static class EVDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EVDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EVDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
