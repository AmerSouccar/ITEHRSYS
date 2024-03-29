﻿using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Custodies.Services
{
    internal class CustodieDomainService : ICustodieDomainService
    {
        private readonly IRepository<Custodie, Guid> _custodieRepository;

        public CustodieDomainService(IRepository<Custodie, Guid> custodieRepository)
        {
            _custodieRepository = custodieRepository;
        }

        public async Task Delete(Guid id)
        {
            await _custodieRepository.DeleteAsync(id);
        }

        public IQueryable<Custodie> GetAll()
        {
            return _custodieRepository.GetAll();
        }

        public async Task<Custodie> GetbyId(Guid id)
        {
            return await _custodieRepository.GetAsync(id);
        }

        public async Task<Custodie> Insert(Custodie custodie)
        {
           return await _custodieRepository.InsertAsync(custodie);
        }

        public async Task<Custodie> Update(Custodie custodie)
        {
            return await _custodieRepository.UpdateAsync(custodie);
        }
    }
}
