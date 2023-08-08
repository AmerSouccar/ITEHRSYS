using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.MilitaryServices.Services
{
    public class MilitaryServiceDomainService : IMilitaryServiceDomainService
    {
        private readonly IRepository<MilitaryService, Guid> _militaryServiceRepository;

        public MilitaryServiceDomainService(IRepository<MilitaryService, Guid> militaryServiceRepository)
        {
            _militaryServiceRepository = militaryServiceRepository;
        }

        public async Task Delete(Guid id)
        {
            await _militaryServiceRepository.DeleteAsync(id);
        }

        public IQueryable<MilitaryService> GetAll()
        {
           return _militaryServiceRepository.GetAllIncluding(x => x.Attachments);
        }

        public async Task<MilitaryService> GetbyId(Guid id)
        {
            return _militaryServiceRepository.GetAllIncluding(x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<MilitaryService> Insert(MilitaryService militaryService)
        {
            return await _militaryServiceRepository.InsertAsync(militaryService);
        }

        public async Task<MilitaryService> Update(MilitaryService militaryService)
        {
            return await _militaryServiceRepository.UpdateAsync(militaryService);
        }
    }
}
