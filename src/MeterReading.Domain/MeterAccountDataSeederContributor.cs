using MeterReading.Meters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace MeterReading
{
  public  class MeterAccountDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IMeterAccountRepository _meterAccountRepository;
        private readonly MeterAccountManager _meterAccountManager;
        public MeterAccountDataSeederContributor(IMeterAccountRepository meterAccountRepository, MeterAccountManager meterAccountManager)
        {
            _meterAccountRepository = meterAccountRepository;
            _meterAccountManager = meterAccountManager;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            // throw new NotImplementedException();
            if (await _meterAccountRepository.GetCountAsync() > 0)
            {
                return;
            }

            var dy = await _meterAccountRepository.InsertAsync(
                await _meterAccountManager.CreateAsync(
                          "中变1号总电量",//MeterName =
                          "0",//MeterLevel =
                          "12010001",//FatherMeterID =
                          false,//IsVirtual =
                          "",//SpareFor =
                         "杜云",//Reader = 
                          "dy",//UserName =
                          "",//RouteNO1 =
                          "",//RouteNO2 =
                          "",//RouteNO3 =
                           "",//PlantID =
                         "",// MediaType =
                         "",//UserType =
                          "",//ReportCycle =
                          "12010002",//MeterID =
                          0.0f,//Magnification =
                          0,//Peak =
                          0,//Valley =
                          0,//Flat =
                          0L,//Value =
                           0L,//PerValue=
                         0.0f,//DiffValue = 
                          0.0f,//adjustment =
                          0.0f,//ReportValue =
                          0.0f,//PerReportValue =
                          0.0f,//DiffReportValue =
                         0.0f,//Temperature = 
                          0.0f,//Pressure =
                         "20201201",// CurrentCycle =
                         0.0f,
                         false,
                         false
                )
            );


            //-----

            var lx = await _meterAccountRepository.InsertAsync(
               await _meterAccountManager.CreateAsync(
                         "中变1号总电量",//MeterName =
                         "0",//MeterLevel =
                         "12010001",//FatherMeterID =
                         false,//IsVirtual =
                         "",//SpareFor =
                        "刘鑫",//Reader = 
                         "lx",//UserName =
                         "",//RouteNO1 =
                         "",//RouteNO2 =
                         "",//RouteNO3 =
                          "",//PlantID =
                        "",// MediaType =
                        "",//UserType =
                         "",//ReportCycle =
                         "12010003",//MeterID =
                         0.0f,//Magnification =
                         0,//Peak =
                         0,//Valley =
                         0,//Flat =
                         0L,//Value =
                          0L,//PerValue=
                        0.0f,//DiffValue = 
                         0.0f,//adjustment =
                         0.0f,//ReportValue =
                         0.0f,//PerReportValue =
                         0.0f,//DiffReportValue =
                        0.0f,//Temperature = 
                         0.0f,//Pressure =
                        "20201201",// CurrentCycle =
                        0.0f,
                         false,
                         false
               )
           );



        }


    }
}
