using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace MeterReading.Meters
{
   public class MeterAccountManager : DomainService
    {
        private readonly IMeterAccountRepository _meterAccountRepository;
        public MeterAccountManager(IMeterAccountRepository meterAccountRepository)
        {
            _meterAccountRepository = meterAccountRepository;
        }

        public async Task<MeterAccount> CreateAsync(
     string MeterName,
string MeterLevel,
string FatherMeterID,
 bool IsVirtual,
 string SpareFor,
string Reader,
 string UserName,
 string RouteNO1,
string RouteNO2,
string RouteNO3,
 string PlantID,
string MediaTypeID,
string UserTypeID,
 string ReportCycleID,
 string MeterID,
 float Magnification,
int Peak,
 int Valley,
int Flat,
 long Value,
long PerValue,
 float DiffValue,
 float Adjustment,
 float ReportValue,
 float PerReportValue,
 float DiffReportValue,
float Temperature,
 float Pressure,
 string CurrentCycle,
 float BalanceRatio,
       bool IsBalance ,
        bool IsEnable 
 )
        {
            Check.NotNullOrWhiteSpace(MeterID, nameof(MeterID));

            var existingMeterAccount = await _meterAccountRepository.FindByMeterIDAsync(MeterID);
            if (existingMeterAccount != null)
            {
                // throw new AuthorAlreadyExistsException(name);
            }

            return new MeterAccount(
             GuidGenerator.Create(),
             MeterName,
             MeterLevel,
             FatherMeterID,
             IsVirtual,
             SpareFor,
             Reader,
             UserName,
             RouteNO1,
             RouteNO2,
             RouteNO3,
             PlantID,
             MediaTypeID,
             UserTypeID,
             ReportCycleID,
             MeterID,
             Magnification,
             Peak,
             Valley,
             Flat,
             Value,
             PerValue,
             DiffValue,
             Adjustment,
             ReportValue,
             PerReportValue,
             DiffReportValue,
             Temperature,
             Pressure,
             CurrentCycle,
              BalanceRatio,
          IsBalance,
           IsEnable
            );
        }

        public async Task ChangeMeterIDAsync(
                   [NotNull] MeterAccount meterAccount,
                   [NotNull] string newMeterID)
        {
            Check.NotNull(meterAccount, nameof(meterAccount));
            Check.NotNullOrWhiteSpace(newMeterID, nameof(newMeterID));

            var existingMeterAccount = await _meterAccountRepository.FindByMeterIDAsync(newMeterID);
            if (existingMeterAccount != null && existingMeterAccount.Id != meterAccount.Id)
            {
                //   throw new AuthorAlreadyExistsException(newName);
            }

            meterAccount.ChangeMeterID(newMeterID);
        }


    }
}
