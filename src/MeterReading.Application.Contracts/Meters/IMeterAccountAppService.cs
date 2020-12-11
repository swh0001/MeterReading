using System;
using MeterReading.Meters.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MeterReading.Meters
{
    public interface IMeterAccountAppService :
        ICrudAppService< 
            MeterAccountDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateMeterAccountDto,
            CreateUpdateMeterAccountDto>
    {

    }
}