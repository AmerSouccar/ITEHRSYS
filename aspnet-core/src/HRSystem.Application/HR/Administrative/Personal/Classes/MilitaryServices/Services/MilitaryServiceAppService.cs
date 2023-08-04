using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Classes.MilitaryServices.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.MilitaryServices.Services
{
    public class MilitaryServiceAppService : HRSystemAppServiceBase, IMilitaryServiceAppService
    {
        private readonly IMilitaryServiceDomainService _militaryServiceDomainService;

        public MilitaryServiceAppService(IMilitaryServiceDomainService militaryServiceDomainService)
        {
            _militaryServiceDomainService = militaryServiceDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _militaryServiceDomainService.Delete(id);
        }

        public PagedResultDto<ReadMilitaryServiceDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var militaryServices = _militaryServiceDomainService.GetAll();
            int total = militaryServices.Count();
            militaryServices = militaryServices.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadMilitaryServiceDto>>(militaryServices.ToList());
            return new PagedResultDto<ReadMilitaryServiceDto>(total, list);
        }

        public async Task<ReadMilitaryServiceDto> GetbyId(Guid id)
        {
           return ObjectMapper.Map<ReadMilitaryServiceDto>(await _militaryServiceDomainService.GetbyId(id));
        }

        public async Task<InsertMilitaryServiceDto> Insert(InsertMilitaryServiceDto militaryService)
        {
            return ObjectMapper.Map<InsertMilitaryServiceDto>(await _militaryServiceDomainService.Insert(ObjectMapper.Map<MilitaryService>(militaryService)));
        }

        public async Task<UpdateMilitaryServiceDto> Update(UpdateMilitaryServiceDto militaryService)
        {
            return ObjectMapper.Map<UpdateMilitaryServiceDto>(await _militaryServiceDomainService.Update(ObjectMapper.Map<MilitaryService>(militaryService)));

        }
    }
}
