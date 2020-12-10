using MeterReading.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MeterReading.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MeterReadingController : AbpController
    {
        protected MeterReadingController()
        {
            LocalizationResource = typeof(MeterReadingResource);
        }
    }
}