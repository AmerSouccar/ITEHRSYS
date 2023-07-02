using HRSystem.HR.Administrative.Personal.Classes.Languages.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Languages.Services
{
    public class LanguageAppService : HRSystemAppServiceBase, ILanguageAppService
    {
        private readonly ILanguageDomainService _languageDomainService;

        public LanguageAppService(ILanguageDomainService languageDomainService)
        {
            _languageDomainService = languageDomainService;
        }

        public Task Delete(Guid id)
        {
            return _languageDomainService.Delete(id);
        }

        public async Task<List<ReadLanguageDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadLanguageDto>>(await _languageDomainService.GetAll());
        }

        public async Task<ReadLanguageDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadLanguageDto>(await _languageDomainService.GetbyId(id));
        }

        public async Task<InsertLanguageDto> Insert(InsertLanguageDto language)
        {
           return ObjectMapper.Map<InsertLanguageDto>(await _languageDomainService.Insert(ObjectMapper.Map<Language>(language)));
        }

        public async Task<UpdateLanguageDto> Update(UpdateLanguageDto language)
        {
            return ObjectMapper.Map<UpdateLanguageDto>(await _languageDomainService.Update(ObjectMapper.Map<Language>(language)));

        }
    }
}
