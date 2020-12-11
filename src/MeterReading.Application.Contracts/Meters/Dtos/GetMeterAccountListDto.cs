using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MeterReading.Meters.Dtos
{
   public class GetMeterAccountListDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
