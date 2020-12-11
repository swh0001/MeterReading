using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MeterReading.Meters;
using MeterReading.Meters.Dtos;
//using MeterReading.Web.Pages.Meters.MeterAccountReading.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace MeterReading.Web.Pages.Meters.MeterAccountReading
{
    public class EditModalReadingModel : MeterReadingPageModel//PageModel
    {
        //[HiddenInput]
        //[BindProperty(SupportsGet = true)]
        //public Guid Id { get; set; }

        [BindProperty]
        public EditMeterAccountReading2ViewModel ViewModelReading { get; set; }

        private readonly IMeterAccountReadingAppService _serviceReading;

        public EditModalReadingModel(IMeterAccountReadingAppService serviceReading)
        {
            _serviceReading = serviceReading;
        }
        public virtual async Task OnGetAsync(Guid id)
        {
            var dto = await _serviceReading.GetAsync(id);
            ViewModelReading = ObjectMapper.Map<MeterAccountReadingDto, EditMeterAccountReading2ViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditMeterAccountReading2ViewModel, UpdateMeterAccountReadingDto>(ViewModelReading);
            await _serviceReading.UpdateAsync(ViewModelReading.Id, dto);
            return NoContent();
        }

        //public void OnGet()
        //{
        //}

        public class EditMeterAccountReading2ViewModel
        {
            [HiddenInput]
            public Guid Id { get; set; }
            [Display(Name = "MeterAccountReadingMeterName")]
            public string MeterName { get; set; }
            //public string MeterLevel { get; set; }
            //public string FatherMeterID { get; set; }
            //public bool IsVirtual { get; set; }
            //public string SpareFor { get; set; }
            [Display(Name = "MeterAccountReadingReader")]
            public string Reader { get; set; }
            //public string UserName { get; set; }
            [Display(Name = "MeterAccountReadingRouteNO1")]
            public string RouteNO1 { get; set; }
            [Display(Name = "MeterAccountReadingRouteNO2")]
            public string RouteNO2 { get; set; }
            [Display(Name = "MeterAccountReadingRouteNO3")]
            public string RouteNO3 { get; set; }
            //public string PlantID { get; set; }
            //public string MediaTypeID { get; set; }
            //public string UserTypeID { get; set; }
            //public string ReportCycleID { get; set; }
            [Display(Name = "MeterAccountReadingMeterID")]
            public string MeterID { get; set; }
            //public int Magnification { get; set; }
            //public int Peak { get; set; }
            //public int Valley { get; set; }
            //public int Flat { get; set; }
            [Display(Name = "MeterAccountReadingValue")]
            public int Value { get; set; }
            //public int PerValue { get; set; }
            //public int DiffValue { get; set; }
            //public int Adjustment { get; set; }
            //public int ReportValue { get; set; }
            //public int PerReportValue { get; set; }
            //public int DiffReportValue { get; set; }
            //public int Temperature { get; set; }
            //public float Pressure { get; set; }
            //public string CurrentCycle { get; set; }
        }
    }
}
