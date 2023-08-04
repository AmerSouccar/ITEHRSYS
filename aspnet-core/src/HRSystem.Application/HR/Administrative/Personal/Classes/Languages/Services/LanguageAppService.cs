using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Languages.Dto;
using HRSystem.HR.PaginationDto;
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

        public PagedResultDto<ReadLanguageDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var languages = _languageDomainService.GetAll();
            int total = languages.Count();
            languages = languages.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadLanguageDto>>(languages.ToList());
            return new PagedResultDto<ReadLanguageDto>(total, list);
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
