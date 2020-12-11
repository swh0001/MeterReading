using MeterReading.Meters.Dtos;
using MeterReading.Web.Pages.Meters.MeterAccount.ViewModels;
using AutoMapper;
using static MeterReading.Web.Pages.Meters.MeterAccountReading.EditModalReadingModel;

namespace MeterReading.Web
{
    public class MeterReadingWebAutoMapperProfile : Profile
    {
        public MeterReadingWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            CreateMap<MeterAccountDto, CreateEditMeterAccountViewModel>();
            CreateMap<CreateEditMeterAccountViewModel, CreateUpdateMeterAccountDto>();

            CreateMap<MeterAccountReadingDto, EditMeterAccountReading2ViewModel>();
            CreateMap<EditMeterAccountReading2ViewModel, UpdateMeterAccountReadingDto>();
        }
    }
}
