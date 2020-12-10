using MeterReading.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MeterReading.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MeterReadingPageModel : AbpPageModel
    {
        protected MeterReadingPageModel()
        {
            LocalizationResourceType = typeof(MeterReadingResource);
        }
    }
}