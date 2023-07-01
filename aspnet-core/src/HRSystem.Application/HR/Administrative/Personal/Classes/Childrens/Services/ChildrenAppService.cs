using HRSystem.HR.Administrative.Personal.Classes.Childrens.Dto;
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

        public async Task<List<ReadChildrenDto>> GetAll()
        {
           return ObjectMapper.Map<List<ReadChildrenDto>>(await _childrenDomainService.GetAll());
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
