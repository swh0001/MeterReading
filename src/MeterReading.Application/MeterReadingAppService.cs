using System;
using System.Collections.Generic;
using System.Text;
using MeterReading.Localization;
using Volo.Abp.Application.Services;

namespace MeterReading
{
    /* Inherit your application services from this class.
     */
    public abstract class MeterReadingAppService : ApplicationService
    {
        protected MeterReadingAppService()
        {
            LocalizationResource = typeof(MeterReadingResource);
        }
    }
}
