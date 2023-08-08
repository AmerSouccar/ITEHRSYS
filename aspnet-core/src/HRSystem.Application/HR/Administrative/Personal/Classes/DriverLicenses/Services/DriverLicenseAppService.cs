using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Dependents.Dto;
using HRSystem.HR.Administrative.Personal.Classes.DriverLicenses.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.DriverLicenses.Services
{
    public class DriverLicenseAppService : HRSystemAppServiceBase, IDriverLicenseAppService
    {
        private readonly IDriverLicenseDomainService _driverLicenseDomainService;

        public DriverLicenseAppService(IDriverLicenseDomainService driverLicenseDomainService)
        {
            _driverLicenseDomainService = driverLicenseDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _driverLicenseDomainService.Delete(id);
        }

        public PagedResultDto<ReadDriverLicenseDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var driverLicenses = _driverLicenseDomainService.GetAll();
            int total = driverLicenses.Count();
            driverLicenses = driverLicenses.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadDriverLicenseDto>>(driverLicenses.ToList());
            return new PagedResultDto<ReadDriverLicenseDto>(total, list);
        }

        public async Task<ReadDriverLicenseDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadDriverLicenseDto>(await _driverLicenseDomainService.GetbyId(id));
        }

        public async Task<InsertDriverLicenseDto> Insert(InsertDriverLicenseDto driverLicense)
        {
            return ObjectMapper.Map<InsertDriverLicenseDto>(await _driverLicenseDomainService.Insert(ObjectMapper.Map<DriverLicense>(driverLicense)));
        }

        public async Task<UpdateDriverLicenseDto> Update(UpdateDriverLicenseDto driverLicense)
        {
            return ObjectMapper.Map<UpdateDriverLicenseDto>(await _driverLicenseDomainService.Update(ObjectMapper.Map<DriverLicense>(driverLicense)));

        }
    }
}
