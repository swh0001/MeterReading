using System.Threading.Tasks;

namespace MeterReading.Web.Pages.Meters.MeterAccount
{
    public class IndexModel : MeterReadingPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
