using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MeterReading.Data
{
    /* This is used if database provider does't define
     * IMeterReadingDbSchemaMigrator implementation.
     */
    public class NullMeterReadingDbSchemaMigrator : IMeterReadingDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}