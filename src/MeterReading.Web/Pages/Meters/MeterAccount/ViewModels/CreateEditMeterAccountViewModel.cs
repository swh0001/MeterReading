using System;

using System.ComponentModel.DataAnnotations;

namespace MeterReading.Web.Pages.Meters.MeterAccount.ViewModels
{
    public class CreateEditMeterAccountViewModel
    {
        [Display(Name = "MeterAccountMeterName")]
        public string MeterName { get; set; }

        [Display(Name = "MeterAccountMeterLevel")]
        public string MeterLevel { get; set; }

        [Display(Name = "MeterAccountFatherMeterID")]
        public string FatherMeterID { get; set; }

        [Display(Name = "MeterAccountIsVirtual")]
        public bool IsVirtual { get; set; }

        [Display(Name = "MeterAccountSpareFor")]
        public string SpareFor { get; set; }

        [Display(Name = "MeterAccountReader")]
        public string Reader { get; set; }

        [Display(Name = "MeterAccountUserName")]
        public string UserName { get; set; }

        [Display(Name = "MeterAccountRouteNO1")]
        public string RouteNO1 { get; set; }

        [Display(Name = "MeterAccountRouteNO2")]
        public string RouteNO2 { get; set; }

        [Display(Name = "MeterAccountRouteNO3")]
        public string RouteNO3 { get; set; }

        [Display(Name = "MeterAccountPlantID")]
        public string PlantID { get; set; }

        [Display(Name = "MeterAccountMediaTypeID")]
        public string MediaTypeID { get; set; }

        [Display(Name = "MeterAccountUserTypeID")]
        public string UserTypeID { get; set; }

        [Display(Name = "MeterAccountReportCycleID")]
        public string ReportCycleID { get; set; }

        [Display(Name = "MeterAccountMeterID")]
        public string MeterID { get; set; }

        [Display(Name = "MeterAccountMagnification")]
        public float Magnification { get; set; }

        [Display(Name = "MeterAccountPeak")]
        public int Peak { get; set; }

        [Display(Name = "MeterAccountValley")]
        public int Valley { get; set; }

        [Display(Name = "MeterAccountFlat")]
        public int Flat { get; set; }

        [Display(Name = "MeterAccountValue")]
        public long Value { get; set; }

        [Display(Name = "MeterAccountPerValue")]
        public long PerValue { get; set; }

        [Display(Name = "MeterAccountDiffValue")]
        public float DiffValue { get; set; }

        [Display(Name = "MeterAccountAdjustment")]
        public float Adjustment { get; set; }

        [Display(Name = "MeterAccountReportValue")]
        public float ReportValue { get; set; }

        [Display(Name = "MeterAccountPerReportValue")]
        public float PerReportValue { get; set; }

        [Display(Name = "MeterAccountDiffReportValue")]
        public float DiffReportValue { get; set; }

        [Display(Name = "MeterAccountTemperature")]
        public float Temperature { get; set; }

        [Display(Name = "MeterAccountPressure")]
        public float Pressure { get; set; }

        [Display(Name = "MeterAccountCurrentCycle")]
        public string CurrentCycle { get; set; }

        [Display(Name = "MeterAccountBalanceRatio")]
        public float BalanceRatio { get; set; }

        [Display(Name = "MeterAccountIsBalance")]
        public bool IsBalance { get; set; }

        [Display(Name = "MeterAccountIsEnable")]
        public bool IsEnable { get; set; }
    }
}