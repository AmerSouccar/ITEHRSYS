using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Spouses.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Spouses.Services
{
    public interface ISpouseAppService : IApplicationService
    {
        public PagedResultDto<ReadSpouseDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadSpouseDto> GetbyId(Guid id);
        public Task<InsertSpouseDto> Insert(InsertSpouseDto spouse);
        public Task<UpdateSpouseDto> Update(UpdateSpouseDto spouse);
        public Task Delete(Guid id);
    }
}
