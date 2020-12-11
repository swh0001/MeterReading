using MeterReading.Meters;
using MeterReading.Meters.Dtos;
using AutoMapper;

namespace MeterReading
{
    public class MeterReadingApplicationAutoMapperProfile : Profile
    {
        public MeterReadingApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<MeterAccount, MeterAccountDto>();
            CreateMap<CreateUpdateMeterAccountDto, MeterAccount>(MemberList.Source);

            CreateMap<MeterAccount, MeterAccountReadingDto>();
            // CreateMap<MeterAccount, MeterAccountReadingDto>();

            CreateMap<UpdateMeterAccountReadingDto, MeterAccount>(MemberList.Source);

        }
    }
}
