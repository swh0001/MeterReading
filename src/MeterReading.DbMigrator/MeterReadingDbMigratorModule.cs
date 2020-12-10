using MeterReading.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MeterReading.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MeterReadingEntityFrameworkCoreDbMigrationsModule),
        typeof(MeterReadingApplicationContractsModule)
        )]
    public class MeterReadingDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
