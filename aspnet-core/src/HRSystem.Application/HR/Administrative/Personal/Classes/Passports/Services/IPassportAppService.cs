using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Passports.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Passports.Services
{
    public interface IPassportAppService :IApplicationService
    {
        public Task<List<ReadPassportDto>> GetAll();
        public Task<ReadPassportDto> GetbyId(Guid id);
        public Task<InsertPassportDto> Insert(InsertPassportDto passport);
        public Task<UpdatePassportDto> Update(UpdatePassportDto passport);
        public Task Delete(Guid id);
    }
}
