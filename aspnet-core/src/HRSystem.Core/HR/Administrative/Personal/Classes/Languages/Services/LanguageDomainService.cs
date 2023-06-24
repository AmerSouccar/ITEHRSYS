using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Languages.Services
{
    public class LanguageDomainService : ILanguageDomainService
    {
        private readonly IRepository<Language, Guid> _languageRepository;

        public async Task Delete(Guid id)
        {
            await _languageRepository.DeleteAsync(id);
        }

        public async Task<List<Language>> GetAll()
        {
            return _languageRepository.GetAllIncluding(x => x.LanguageName, x => x.Writing, x => x.Reading, x => x.Speaking, x => x.Listening, x => x.Attachments).ToList();
        }
        public async Task<Language> GetbyId(Guid id)
        {
            return _languageRepository.GetAllIncluding(x => x.LanguageName, x => x.Writing, x => x.Reading, x => x.Speaking, x => x.Listening, x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Language> Insert(Language language)
        {
            return await _languageRepository.InsertAsync(language);
        }

        public async Task<Language> Update(Language language)
        {
            return await _languageRepository.UpdateAsync(language);
        }
    }
}
