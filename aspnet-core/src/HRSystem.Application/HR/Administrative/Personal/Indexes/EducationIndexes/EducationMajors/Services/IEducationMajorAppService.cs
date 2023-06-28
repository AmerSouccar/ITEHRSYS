using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors.Services
{
    public interface IEducationMajorAppService :IApplicationService
    {
        Task<List<EducationMajorDto>> GetAllAsync();
        Task<EducationMajorDto> GetbyId(Guid id);
        Task<EducationMajorDto> InsertAsync(EducationMajorDto educationMajor);
        Task<EducationMajorDto> UpdateAsync(EducationMajorDto educationMajor);
        Task DeleteAsync(Guid id);
    }
}
