using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Indexes.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.LanguageNames.Services
{
    public interface ILanguageNameDomainService : IDomainService
    {
        Task<List<LanguageName>> GetAllAsync();
        Task<LanguageName> GetbyId(Guid id);
        Task<LanguageName> InsertAsync(LanguageName languageName);
        Task<LanguageName> UpdateAsync(LanguageName languageName);
        Task DeleteAsync(Guid id);

    }
}
