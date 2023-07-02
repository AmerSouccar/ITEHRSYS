using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Languages.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Languages.Services
{
    public interface ILanguageAppService :IApplicationService
    {
        public Task<List<ReadLanguageDto>> GetAll();
        public Task<ReadLanguageDto> GetbyId(Guid id);
        public Task<InsertLanguageDto> Insert(InsertLanguageDto language);
        public Task<UpdateLanguageDto> Update(UpdateLanguageDto language);
        public Task Delete(Guid id);
    }
}
