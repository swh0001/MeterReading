using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MeterReading.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class MeterReadingMigrationsDbContextFactory : IDesignTimeDbContextFactory<MeterReadingMigrationsDbContext>
    {
        public MeterReadingMigrationsDbContext CreateDbContext(string[] args)
        {
            MeterReadingEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MeterReadingMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new MeterReadingMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MeterReading.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
