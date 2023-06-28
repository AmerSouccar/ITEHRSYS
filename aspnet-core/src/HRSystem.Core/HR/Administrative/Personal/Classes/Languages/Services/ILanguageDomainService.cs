using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Experiences;
using HRSystem.HR.Administrative.Personal.Indexes.LanguageNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Languages.Services
{
    public interface ILanguageDomainService : IDomainService
    {
        public Task<List<Language>> GetAll();
        public Task<Language> GetbyId(Guid id);
        public Task<Language> Insert(Language language);
        public Task<Language> Update(Language language);
        public Task Delete(Guid id);
        Task<object> Update(LanguageName languageName);
    }
}
