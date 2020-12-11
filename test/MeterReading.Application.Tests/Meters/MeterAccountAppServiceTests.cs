using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace MeterReading.Meters
{
    public class MeterAccountAppServiceTests : MeterReadingApplicationTestBase
    {
        private readonly IMeterAccountAppService _meterAccountAppService;

        public MeterAccountAppServiceTests()
        {
            _meterAccountAppService = GetRequiredService<IMeterAccountAppService>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
        */
    }
}
