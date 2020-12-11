using MeterReading.Meters.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace MeterReading.Meters
{
   public class MeterAccountReadingAppService : MeterReadingAppService, IMeterAccountReadingAppService
    {
        private readonly IMeterAccountRepository _meterAccountRepository;
        private readonly MeterAccountManager _meterAccountManager;

        public MeterAccountReadingAppService(IMeterAccountRepository meterAccountRepository, MeterAccountManager meterAccountManager)
        {
            _meterAccountRepository = meterAccountRepository;
            _meterAccountManager = meterAccountManager;

        }
        public async Task<MeterAccountReadingDto> GetAsync(Guid id)
        {
            var meterAccount = await _meterAccountRepository.GetAsync(id);
            return ObjectMapper.Map<MeterAccount, MeterAccountReadingDto>(meterAccount);
        }

        //-------------

        public async Task<PagedResultDto<MeterAccountReadingDto>> GetListAsync(GetMeterAccountListDto input)
        {
            //throw new NotImplementedException();

            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(MeterAccount.RouteNO1); //默认按线路1排序
            }
            //input.Filter = UserName ?
            input.Filter = CurrentUser.UserName;
            //调用仓储层...从数据库得到列表
            var meterAccounts = await _meterAccountRepository.GetListAsync(
               input.SkipCount,
               input.MaxResultCount,
               input.Sorting,
               input.Filter
           );

            var totalCount = await AsyncExecuter.CountAsync(
                            _meterAccountRepository.WhereIf(
                                !input.Filter.IsNullOrWhiteSpace(),
                                meterAccount => meterAccount.UserName.Equals(input.Filter)
                            )
                        );


            return new PagedResultDto<MeterAccountReadingDto>(
              totalCount,
              ObjectMapper.Map<List<MeterAccount>, List<MeterAccountReadingDto>>(meterAccounts)
          );

        }

        public async Task UpdateAsync(Guid id, UpdateMeterAccountReadingDto input)
        {
            var meterAccount = await _meterAccountRepository.GetAsync(id);

            meterAccount.Value = input.Value;
            meterAccount.RouteNO1 = input.RouteNO1;
            meterAccount.RouteNO2 = input.RouteNO2;
            meterAccount.RouteNO3 = input.RouteNO3;


            await _meterAccountRepository.UpdateAsync(meterAccount);

        }



    }
}
