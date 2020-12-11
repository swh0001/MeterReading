using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace MeterReading.Meters
{
    public interface IMeterAccountRepository : IRepository<MeterAccount, Guid>
    {
        Task<MeterAccount> FindByMeterIDAsync(string meterID);

        Task<List<MeterAccount>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
        );
    }
}