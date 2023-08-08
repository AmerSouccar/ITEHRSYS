using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Childrens.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Childrens.Services
{
    public interface IChildrenAppService : IApplicationService
    {
        public PagedResultDto<ReadChildrenDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadChildrenDto> GetbyId(Guid id);
        public Task<InsertChildrenDto> Insert(InsertChildrenDto children);
        public Task<UpdateChildrenDto> Update(UpdateChildrenDto children);
        public Task Delete(Guid id);
    }
}
