using Abp.Application.Services.Dto;
using Abp.Domain.Services;
using AutoMapper.Internal.Mappers;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles;
using HRSystem.HR.Administrative.Grades.Classes.JobTitles.Dto;
using HRSystem.HR.Administrative.JobDesc.Classes.Positions.Dto;
using HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Dto;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ReadNodeDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var nodes = _nodeDomainService.GetAll();
            int total = nodes.Count();
            nodes = nodes.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadNodeDto>>(nodes.ToList());
            return new PagedResultDto<ReadNodeDto>(total, list);
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
