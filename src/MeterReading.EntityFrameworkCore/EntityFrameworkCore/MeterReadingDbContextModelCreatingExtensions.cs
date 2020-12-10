using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace MeterReading.EntityFrameworkCore
{
    public static class MeterReadingDbContextModelCreatingExtensions
    {
        public static void ConfigureMeterReading(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MeterReadingConsts.DbTablePrefix + "YourEntities", MeterReadingConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}