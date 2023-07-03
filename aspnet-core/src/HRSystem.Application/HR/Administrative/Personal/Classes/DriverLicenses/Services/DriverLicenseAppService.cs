using HRSystem.HR.Administrative.Personal.Classes.DriverLicenses.Dto;
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

        public async Task<List<ReadDriverLicenseDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadDriverLicenseDto>>(await _driverLicenseDomainService.GetAll());    
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
