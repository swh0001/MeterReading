using System;
using MeterReading.Permissions;
using MeterReading.Meters.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MeterReading.Meters
{
    public class MeterAccountAppService : CrudAppService<MeterAccount, MeterAccountDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMeterAccountDto, CreateUpdateMeterAccountDto>,
        IMeterAccountAppService
    {
        protected override string GetPolicyName { get; set; } = MeterReadingPermissions.MeterAccount.Default;
        protected override string GetListPolicyName { get; set; } = MeterReadingPermissions.MeterAccount.Default;
        protected override string CreatePolicyName { get; set; } = MeterReadingPermissions.MeterAccount.Create;
        protected override string UpdatePolicyName { get; set; } = MeterReadingPermissions.MeterAccount.Update;
        protected override string DeletePolicyName { get; set; } = MeterReadingPermissions.MeterAccount.Delete;

        private readonly IMeterAccountRepository _repository;
        
        public MeterAccountAppService(IMeterAccountRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
