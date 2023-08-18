using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Services
{
    public interface INodeAppService : IApplicationService
    {
        public PagedResultDto<ReadNodeDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadNodeDto> GetbyId(Guid id);
        public Task<UpdateNodeDto> GetForEdit(Guid id);
        public Task<InsertNodeDto> Insert(InsertNodeDto insertNodeDto);
        public Task<UpdateNodeDto> Update(UpdateNodeDto updateNodeDto);
        public Task Delete(Guid id);
    }
}
