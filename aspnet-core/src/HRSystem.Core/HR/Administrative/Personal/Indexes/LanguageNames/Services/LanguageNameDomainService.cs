using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.LanguageNames.Services
{
    public class LanguageNameDomainService : ILanguageNameDomainService
    {
        private readonly IRepository<LanguageName, Guid> _languageNames;

        public LanguageNameDomainService(IRepository<LanguageName, Guid> languageNames)
        {
            _languageNames = languageNames;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _languageNames.DeleteAsync(id);
        }

        public async Task<LanguageName> GetbyId(Guid id)
        {
            return await _languageNames.GetAsync(id);
        }

        public async Task<List<LanguageName>> GetCitiesAsync()
        {
            return await _languageNames.GetAllListAsync();
        }

        public async Task<LanguageName> InsertAsync(LanguageName languageName)
        {
            return await _languageNames.InsertAsync(languageName);
        }

        public async Task<LanguageName> UpdateAsync(LanguageName languageName)
        {
            return await _languageNames.UpdateAsync(languageName);
        }
    }
}
