﻿using HRSystem.HR.Administrative.Personal.Classes.Languages.Services;
using HRSystem.HR.Administrative.Personal.Indexes.LanguageNames.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.LanguageNames.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.LanguageNames.Service
{
    public class LanguageNameAppService : HRSystemAppServiceBase, ILanguageNameAppService
    {
        private readonly ILanguageNameDomainService _languageNameDomainService;
        public LanguageNameAppService(ILanguageNameDomainService languageNameDomainService)
        {
            _languageNameDomainService = languageNameDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _languageNameDomainService.DeleteAsync(id);
        }

        public async Task<List<LanguageNameDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<LanguageNameDto>>(await _languageNameDomainService.GetAllAsync());
        }

        public async Task<LanguageNameDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<LanguageNameDto>(await _languageNameDomainService.GetbyId(id));
        }

        public async Task<LanguageNameDto> InsertAsync(LanguageNameDto languageName)
        {
            return ObjectMapper.Map<LanguageNameDto>(await _languageNameDomainService.InsertAsync(ObjectMapper.Map<LanguageName>(languageName)));
        }

        public async Task<LanguageNameDto> UpdateAsync(LanguageNameDto languageName)
        {
            return ObjectMapper.Map<LanguageNameDto>(await _languageNameDomainService.UpdateAsync(ObjectMapper.Map<LanguageName>(languageName)));

        }
    }
}
