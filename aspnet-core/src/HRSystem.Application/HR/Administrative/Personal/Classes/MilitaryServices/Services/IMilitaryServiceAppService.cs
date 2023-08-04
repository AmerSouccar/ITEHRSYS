using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.MilitaryServices.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.MilitaryServices.Services
{
    public interface IMilitaryServiceAppService :IApplicationService
    {
        public PagedResultDto<ReadMilitaryServiceDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadMilitaryServiceDto> GetbyId(Guid id);
        public Task<InsertMilitaryServiceDto> Insert(InsertMilitaryServiceDto militaryService);
        public Task<UpdateMilitaryServiceDto> Update(UpdateMilitaryServiceDto militaryService);
        public Task Delete(Guid id);
    }
}
