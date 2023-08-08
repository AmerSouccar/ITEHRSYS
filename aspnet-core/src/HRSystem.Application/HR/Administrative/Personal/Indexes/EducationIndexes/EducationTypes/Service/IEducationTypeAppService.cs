using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationTypes.Service
{
    public interface IEducationTypeAppService : IApplicationService
    {
        PagedResultDto<EducationTypeDto> GetAll(PagedGeneralResultRequestDto input);
        Task<EducationTypeDto> GetbyId(Guid id);
        Task<EducationTypeDto> InsertAsync(EducationTypeDto educationType);
        Task<EducationTypeDto> UpdateAsync(EducationTypeDto educationType);
        Task DeleteAsync(Guid id);
    }
}
