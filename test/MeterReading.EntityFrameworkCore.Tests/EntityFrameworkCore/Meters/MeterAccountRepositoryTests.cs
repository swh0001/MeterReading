using System;
using System.Threading.Tasks;
using MeterReading.Meters;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace MeterReading.EntityFrameworkCore.Meters
{
    public class MeterAccountRepositoryTests : MeterReadingEntityFrameworkCoreTestBase
    {
        private readonly IMeterAccountRepository _meterAccountRepository;

        public MeterAccountRepositoryTests()
        {
            _meterAccountRepository = GetRequiredService<IMeterAccountRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
