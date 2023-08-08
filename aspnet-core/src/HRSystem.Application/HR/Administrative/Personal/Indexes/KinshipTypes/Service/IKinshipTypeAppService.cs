using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Service
{
    public interface IKinshipTypeAppService :IApplicationService
    {
        PagedResultDto<KinshipTypeDto> GetAll(PagedGeneralResultRequestDto input);
        Task<KinshipTypeDto> GetbyId(Guid id);
        Task<KinshipTypeDto> InsertAsync(KinshipTypeDto kinshipType);
        Task<KinshipTypeDto> UpdateAsync(KinshipTypeDto kinshipType);
        Task DeleteAsync(Guid id);
    }
}
