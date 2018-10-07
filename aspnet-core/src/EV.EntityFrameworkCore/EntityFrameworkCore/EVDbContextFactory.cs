using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using EV.Configuration;
using EV.Web;

namespace EV.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EVDbContextFactory : IDesignTimeDbContextFactory<EVDbContext>
    {
        public EVDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EVDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());
            EVDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EVConsts.ConnectionStringName));

            return new EVDbContext(builder.Options);
        }
    }
}
