using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeterReading.Meters;
using MeterReading.Meters.Dtos;
using MeterReading.Web.Pages.Meters.MeterAccount.ViewModels;

namespace MeterReading.Web.Pages.Meters.MeterAccount
{
    public class EditModalModel : MeterReadingPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditMeterAccountViewModel ViewModel { get; set; }

        private readonly IMeterAccountAppService _service;

        public EditModalModel(IMeterAccountAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<MeterAccountDto, CreateEditMeterAccountViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditMeterAccountViewModel, CreateUpdateMeterAccountDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}