using Volo.Abp.Modularity;

namespace MeterReading
{
    [DependsOn(
        typeof(MeterReadingApplicationModule),
        typeof(MeterReadingDomainTestModule)
        )]
    public class MeterReadingApplicationTestModule : AbpModule
    {

    }
}