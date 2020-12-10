using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MeterReading.EntityFrameworkCore
{
    [DependsOn(
        typeof(MeterReadingEntityFrameworkCoreModule)
        )]
    public class MeterReadingEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MeterReadingMigrationsDbContext>();
        }
    }
}
