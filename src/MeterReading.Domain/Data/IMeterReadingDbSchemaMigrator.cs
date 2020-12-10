using System.Threading.Tasks;

namespace MeterReading.Data
{
    public interface IMeterReadingDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
