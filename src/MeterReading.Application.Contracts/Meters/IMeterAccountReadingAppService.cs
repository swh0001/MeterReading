using MeterReading.Meters.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MeterReading.Meters
{
  public interface IMeterAccountReadingAppService : IApplicationService
    {

        Task<MeterAccountReadingDto> GetAsync(Guid id);

        Task<PagedResultDto<MeterAccountReadingDto>> GetListAsync(GetMeterAccountListDto input);

        // Task<AuthorDto> CreateAsync(CreateAuthorDto input);

        Task UpdateAsync(Guid id, UpdateMeterAccountReadingDto input);
    }
}
