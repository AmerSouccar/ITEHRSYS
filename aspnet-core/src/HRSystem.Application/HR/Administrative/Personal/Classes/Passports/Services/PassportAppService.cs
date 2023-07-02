using HRSystem.HR.Administrative.Personal.Classes.Passports.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Passports.Services
{
    public class PassportAppService : HRSystemAppServiceBase, IPassportAppService
    {
        private readonly IPassportDomainService _passportDomainService;

        public PassportAppService(IPassportDomainService passportDomainService)
        {
            _passportDomainService = passportDomainService;
        }

        public async Task Delete(Guid id)
        {
            await _passportDomainService.Delete(id);
        }

        public async Task<List<ReadPassportDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadPassportDto>>(await _passportDomainService.GetAll());
        }

        public async Task<ReadPassportDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadPassportDto>(await _passportDomainService.GetbyId(id));
        }

        public async Task<InsertPassportDto> Insert(InsertPassportDto passport)
        {
            return ObjectMapper.Map<InsertPassportDto>(await _passportDomainService.Insert(ObjectMapper.Map<Passport>(passport)));
        }

        public async Task<UpdatePassportDto> Update(UpdatePassportDto passport)
        {
            return ObjectMapper.Map<UpdatePassportDto>(await _passportDomainService.Update(ObjectMapper.Map<Passport>(passport)));

        }
    }
}
