using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Services;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.KinshipTypes.Service
{
    public class KinshipTypeAppService : HRSystemAppServiceBase, IKinshipTypeAppService
    {
        private readonly IKinshipTypeDomainService _kinshipTypedomainService;

        public KinshipTypeAppService(IKinshipTypeDomainService kinshipTypedomainService)
        {
            _kinshipTypedomainService = kinshipTypedomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
          await _kinshipTypedomainService.DeleteAsync(id);
        }

        public PagedResultDto<KinshipTypeDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var kinshipTypes = _kinshipTypedomainService.GetAll();
            int total = kinshipTypes.Count();
            kinshipTypes = kinshipTypes.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<KinshipTypeDto>>(kinshipTypes.ToList());
            return new PagedResultDto<KinshipTypeDto>(total, list);
        }

        public async Task<KinshipTypeDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<KinshipTypeDto>(await _kinshipTypedomainService.GetbyId(id));
        }

        public async Task<KinshipTypeDto> InsertAsync(KinshipTypeDto kinshipType)
        {
           return ObjectMapper.Map<KinshipTypeDto>(await _kinshipTypedomainService.InsertAsync(ObjectMapper.Map<KinshipType>(kinshipType)));
        }

        public async Task<KinshipTypeDto> UpdateAsync(KinshipTypeDto kinshipType)
        {
            return ObjectMapper.Map<KinshipTypeDto>(await _kinshipTypedomainService.UpdateAsync(ObjectMapper.Map<KinshipType>(kinshipType)));

        }
    }
}
