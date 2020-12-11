using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MeterReading.Meters
{
    public static class MeterAccountEfCoreQueryableExtensions
    {
        public static IQueryable<MeterAccount> IncludeDetails(this IQueryable<MeterAccount> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}