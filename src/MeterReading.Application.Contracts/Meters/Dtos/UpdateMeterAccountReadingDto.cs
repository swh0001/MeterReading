using System;
using System.Collections.Generic;
using System.Text;

namespace MeterReading.Meters.Dtos
{
   public class UpdateMeterAccountReadingDto
    {
        public string MeterName { get; set; }
        //public string MeterLevel { get; set; }
        //public string FatherMeterID { get; set; }
        //public bool IsVirtual { get; set; }
        //public string SpareFor { get; set; }
        public string Reader { get; set; }
        //public string UserName { get; set; }
        public string RouteNO1 { get; set; }
        public string RouteNO2 { get; set; }
        public string RouteNO3 { get; set; }
        //public string PlantID { get; set; }
        //public string MediaTypeID { get; set; }
        //public string UserTypeID { get; set; }
        //public string ReportCycleID { get; set; }
        public string MeterID { get; set; }
        //public int Magnification { get; set; }
        //public int Peak { get; set; }
        //public int Valley { get; set; }
        //public int Flat { get; set; }
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
