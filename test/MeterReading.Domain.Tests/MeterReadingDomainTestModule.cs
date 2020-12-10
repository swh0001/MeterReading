using MeterReading.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MeterReading
{
    [DependsOn(
        typeof(MeterReadingEntityFrameworkCoreTestModule)
        )]
    public class MeterReadingDomainTestModule : AbpModule
    {

    }
}