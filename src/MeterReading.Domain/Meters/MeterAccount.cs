using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace MeterReading.Meters
{
    public class MeterAccount : FullAuditedAggregateRoot<Guid>
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
        public string MeterID { get; private set; }
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
       // public decimal MyProperty { get; set; }











        protected MeterAccount()
        {
            /* This constructor is for deserialization / ORM purpose */
        }

        public MeterAccount(
            Guid id,
            string meterName,
            string meterLevel,
            string fatherMeterID,
            bool isVirtual,
            string spareFor,
            string reader,
            string userName,
            string routeNO1,
            string routeNO2,
            string routeNO3,
            string plantID,
            string mediaTypeID,
            string userTypeID,
            string reportCycleID,
            [NotNull] string meterID,
            float magnification,
            int peak,
            int valley,
            int flat,
            long value,
            long perValue,
            float diffValue,
            float adjustment,
            float reportValue,
            float perReportValue,
            float diffReportValue,
            float temperature,
            float pressure,
            string currentCycle,
            float balanceRatio,
            bool isBalance,
            bool isEnable
        ) : base(id)
        {
            MeterName = meterName;
            MeterLevel = meterLevel;
            FatherMeterID = fatherMeterID;
            IsVirtual = isVirtual;
            SpareFor = spareFor;
            Reader = reader;
            UserName = userName;
            RouteNO1 = routeNO1;
            RouteNO2 = routeNO2;
            RouteNO3 = routeNO3;
            PlantID = plantID;
            MediaTypeID = mediaTypeID;
            UserTypeID = userTypeID;
            ReportCycleID = reportCycleID;
            SetMeterID(meterID);
            Magnification = magnification;
            Peak = peak;
            Valley = valley;
            Flat = flat;
            Value = value;
            PerValue = perValue;
            DiffValue = diffValue;
            Adjustment = adjustment;
            ReportValue = reportValue;
            PerReportValue = perReportValue;
            DiffReportValue = diffReportValue;
            Temperature = temperature;
            Pressure = pressure;
            CurrentCycle = currentCycle;
            BalanceRatio = balanceRatio;
            IsBalance = isBalance;
            IsEnable = isEnable;
        }

        private void SetMeterID([NotNull] string meterID)
        {
            MeterID = Check.NotNullOrWhiteSpace(meterID, nameof(meterID), 16);
        }

        internal MeterAccount ChangeMeterID([NotNull] string meterID)
        {
            SetMeterID(meterID);
            return this; //返回改完名字的实体,供Manager中调用

        }

    }
}
