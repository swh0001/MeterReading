using System;
using Volo.Abp.Application.Dtos;

namespace MeterReading.Meters.Dtos
{
    [Serializable]
    public class MeterAccountDto : FullAuditedEntityDto<Guid>
    {
        public string MeterName { get; set; }

        public string MeterLevel { get; set; }

        public string FatherMeterID { get; set; }

        public bool IsVirtual { get; set; }

        public string SpareFor { get; set; }

        public string Reader { get; set; }

        public string UserName { get; set; }

        public string RouteNO1 { get; set; }

        public string RouteNO2 { get; set; }

        public string RouteNO3 { get; set; }

        public string PlantID { get; set; }

        public string MediaTypeID { get; set; }

        public string UserTypeID { get; set; }

        public string ReportCycleID { get; set; }

        public string MeterID { get; set; }

        public float Magnification { get; set; }

        public int Peak { get; set; }

        public int Valley { get; set; }

        public int Flat { get; set; }

        public long Value { get; set; }

        public long PerValue { get; set; }

        public float DiffValue { get; set; }

        public float Adjustment { get; set; }

        public float ReportValue { get; set; }

        public float PerReportValue { get; set; }

        public float DiffReportValue { get; set; }

        public float Temperature { get; set; }

        public float Pressure { get; set; }

        public string CurrentCycle { get; set; }

        public float BalanceRatio { get; set; }

        public bool IsBalance { get; set; }

        public bool IsEnable { get; set; }
    }
}