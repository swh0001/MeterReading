using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MeterReading.Pages
{
    public class Index_Tests : MeterReadingWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
