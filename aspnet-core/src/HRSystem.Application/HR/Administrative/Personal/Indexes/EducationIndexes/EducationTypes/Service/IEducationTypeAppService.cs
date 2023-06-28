using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Service
{
    public interface IEducationTypeAppService : IApplicationService
    {
        Task<List<EducationTypeDto>> GetAllAsync();
        Task<EducationTypeDto> GetbyId(Guid id);
        Task<EducationTypeDto> InsertAsync(EducationTypeDto educationType);
        Task<EducationTypeDto> UpdateAsync(EducationTypeDto educationType);
        Task DeleteAsync(Guid id);
    }
}
