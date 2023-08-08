using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors.Services
{
    public interface IEducationMajorAppService :IApplicationService
    {
        PagedResultDto<EducationMajorDto> GetAll(PagedGeneralResultRequestDto input);
        Task<EducationMajorDto> GetbyId(Guid id);
        Task<EducationMajorDto> InsertAsync(EducationMajorDto educationMajor);
        Task<EducationMajorDto> UpdateAsync(EducationMajorDto educationMajor);
        Task DeleteAsync(Guid id);
    }
}
