using Abp.Domain.Services;
using AutoMapper.Internal.Mappers;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Services
{
    public class NodeAppService : HRSystemAppServiceBase, INodeAppService
    {
        private readonly INodeDomainService _nodeDomainService;

        public NodeAppService(INodeDomainService nodeDomainService)
        {
            _nodeDomainService = nodeDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _nodeDomainService.Delete(id);
        }

        public async Task<List<ReadNodeDto>> GetAll()
        {
           return ObjectMapper.Map<List<ReadNodeDto>> (await _nodeDomainService.GetAll());
        }

        public async Task<ReadNodeDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadNodeDto>(await _nodeDomainService.GetbyId(id));

        }

        public async Task<InsertNodeDto> Insert(InsertNodeDto insertNodeDto)
        {
            return ObjectMapper.Map<InsertNodeDto>(await _nodeDomainService.Insert(ObjectMapper.Map<Node>(insertNodeDto)));

        }

        public async Task<UpdateNodeDto> Update(UpdateNodeDto updateNodeDto)
        {
            return ObjectMapper.Map<UpdateNodeDto>(await _nodeDomainService.Update(ObjectMapper.Map<Node>(updateNodeDto)));

        }
    }
}
