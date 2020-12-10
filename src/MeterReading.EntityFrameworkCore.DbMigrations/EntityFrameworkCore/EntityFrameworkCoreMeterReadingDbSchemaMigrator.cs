using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MeterReading.Data;
using Volo.Abp.DependencyInjection;

namespace MeterReading.EntityFrameworkCore
{
    public class EntityFrameworkCoreMeterReadingDbSchemaMigrator
        : IMeterReadingDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMeterReadingDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MeterReadingMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<MeterReadingMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}