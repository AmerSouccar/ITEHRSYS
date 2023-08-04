using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.DriverLicenses.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.DriverLicenses.Services
{
    public interface IDriverLicenseAppService :IApplicationService
    {
        public PagedResultDto<ReadDriverLicenseDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadDriverLicenseDto> GetbyId(Guid id);
        public Task<InsertDriverLicenseDto> Insert(InsertDriverLicenseDto driverLicense);
        public Task<UpdateDriverLicenseDto> Update(UpdateDriverLicenseDto driverLicense);
        public Task Delete(Guid id);
    }
}
