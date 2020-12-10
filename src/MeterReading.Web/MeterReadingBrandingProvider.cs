using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MeterReading.Web
{
    [Dependency(ReplaceServices = true)]
    public class MeterReadingBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MeterReading";
    }
}
