using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Convictions.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Convictions.Services
{
    public interface IConvictionAppService :IApplicationService
    {
        public PagedResultDto<ReadConvictionDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadConvictionDto> GetbyId(Guid id);
        public Task<InsertConvictionDto> Insert(InsertConvictionDto conviction);
        public Task<UpdateConvictionDto> Update(UpdateConvictionDto conviction);
        public Task Delete(Guid id);
    }
}
