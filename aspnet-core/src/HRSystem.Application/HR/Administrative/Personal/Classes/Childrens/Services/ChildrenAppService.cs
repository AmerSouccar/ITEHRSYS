using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Banks.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Childrens.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Childrens.Services
{
    public class ChildrenAppService : HRSystemAppServiceBase, IChildrenAppService
    {
        private readonly IChildrenDomainService _childrenDomainService;

        public ChildrenAppService(IChildrenDomainService childrenDomainService)
        {
            _childrenDomainService = childrenDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _childrenDomainService.Delete(id);
        }

        public PagedResultDto<ReadChildrenDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var childrens = _childrenDomainService.GetAll();
            int total = childrens.Count();
            childrens = childrens.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadChildrenDto>>(childrens.ToList());
            return new PagedResultDto<ReadChildrenDto>(total, list);
        }

        public async Task<ReadChildrenDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadChildrenDto>(await _childrenDomainService.GetbyId(id));
        }

        public async Task<InsertChildrenDto> Insert(InsertChildrenDto children)
        {
            return ObjectMapper.Map<InsertChildrenDto>(await _childrenDomainService.Insert(ObjectMapper.Map<Children>(children)));
        }

        public async Task<UpdateChildrenDto> Update(UpdateChildrenDto children)
        {
            return ObjectMapper.Map<UpdateChildrenDto>(await _childrenDomainService.Update(ObjectMapper.Map<Children>(children)));
        }
    }
}
