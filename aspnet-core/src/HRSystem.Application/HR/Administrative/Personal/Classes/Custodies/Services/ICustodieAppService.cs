using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Custodies.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Custodies.Services
{
    public interface ICustodieAppService : IApplicationService
    {
        public PagedResultDto<ReadCustodieDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadCustodieDto> GetbyId(Guid id);
        public Task<InsertCustodieDto> Insert(InsertCustodieDto custodie);
        public Task<UpdateCustodieDto> Update(UpdateCustodieDto custodie);
        public Task Delete(Guid id);
    }
}
