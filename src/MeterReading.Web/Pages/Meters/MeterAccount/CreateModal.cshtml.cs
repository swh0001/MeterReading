using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeterReading.Meters;
using MeterReading.Meters.Dtos;
using MeterReading.Web.Pages.Meters.MeterAccount.ViewModels;

namespace MeterReading.Web.Pages.Meters.MeterAccount
{
    public class CreateModalModel : MeterReadingPageModel
    {
        [BindProperty]
        public CreateEditMeterAccountViewModel ViewModel { get; set; }

        private readonly IMeterAccountAppService _service;

        public CreateModalModel(IMeterAccountAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditMeterAccountViewModel, CreateUpdateMeterAccountDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}