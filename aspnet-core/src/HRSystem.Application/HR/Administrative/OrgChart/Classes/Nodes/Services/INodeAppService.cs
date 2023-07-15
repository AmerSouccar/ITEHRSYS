using Abp.Application.Services;
using HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Services
{
    public interface INodeAppService : IApplicationService
    {
        public Task<List<ReadNodeDto>> GetAll();
        public Task<ReadNodeDto> GetbyId(Guid id);
        public Task<InsertNodeDto> Insert(InsertNodeDto insertNodeDto);
        public Task<UpdateNodeDto> Update(UpdateNodeDto updateNodeDto);
        public Task Delete(Guid id);
    }
}
