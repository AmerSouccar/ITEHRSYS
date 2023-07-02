using HRSystem.HR.Administrative.Personal.Classes.MilitaryServices.Dto;
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

        public async Task<List<ReadMilitaryServiceDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadMilitaryServiceDto>>(await _militaryServiceDomainService.GetAll());
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
