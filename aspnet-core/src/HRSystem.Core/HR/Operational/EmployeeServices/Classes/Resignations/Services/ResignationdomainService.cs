using Abp.Domain.Repositories;
using HRSystem.HR.Operational.EmployeeServices.Classes.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Services
{
    public class ResignationdomainService : IResignationdomainService
    {
        private readonly IRepository<Resignation,Guid> _resignationRepository;

        public ResignationdomainService(IRepository<Resignation, Guid> resignationRepository)
        {
            _resignationRepository = resignationRepository;
        }

        public async Task Delete(Guid id)
        {
            await _resignationRepository.DeleteAsync(id);
        }

        public IQueryable<Resignation> GetAll()
        {
            return _resignationRepository.GetAllIncluding(x => x.EmployeeCard);
        }

        public async Task<Resignation> GetbyId(Guid id)
        {
            Resignation resignation = await _resignationRepository.GetAsync(id);
            if (resignation != null)
            {
                await _resignationRepository.EnsurePropertyLoadedAsync(resignation, x => x.EmployeeCard);
            }
            return resignation;
        }

        public async Task<Resignation> Insert(Resignation resignation)
        {
            return await _resignationRepository.InsertAsync(resignation);
        }

        public async Task<Resignation> Update(Resignation resignation)
        {
            return await _resignationRepository.UpdateAsync(resignation);

        }
    }
}
