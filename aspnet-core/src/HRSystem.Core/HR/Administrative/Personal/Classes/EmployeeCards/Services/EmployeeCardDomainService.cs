﻿using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.EmployeeCards.Services
{
    public class EmployeeCardDomainService : IEmployeeCardDomainService
    {
        private readonly IRepository<ReadEmployeeCardDto, Guid> _employeeCardRepository;

        public EmployeeCardDomainService(IRepository<ReadEmployeeCardDto, Guid> employeeCardRepository)
        {
            _employeeCardRepository = employeeCardRepository;
        }

        public async Task Delete(Guid id)
        {
            await _employeeCardRepository.DeleteAsync(id);
        }

        public async Task<List<ReadEmployeeCardDto>> GetAll()
        {
            return _employeeCardRepository.GetAllIncluding(x => x.JobDescription, x => x.Employee, x => x.Position, x => x.JobTitle, x => x.Grade, x => x.Custodies, x => x.Assignments, x => x.Transfers, x => x.Resignations, x => x.Promotions, x => x.LeaveRequests).ToList();
        }

        public async Task<ReadEmployeeCardDto> GetbyId(Guid id)
        {
            return _employeeCardRepository.GetAllIncluding(x => x.JobDescription, x => x.Employee, x => x.Position, x => x.JobTitle, x => x.Grade, x => x.Custodies, x => x.Assignments, x => x.Transfers, x => x.Resignations, x => x.Promotions, x => x.LeaveRequests).FirstOrDefault(x => x.Id == id);
        }

        public async Task<ReadEmployeeCardDto> Insert(ReadEmployeeCardDto employeeCard)
        {
           return await _employeeCardRepository.InsertAsync(employeeCard);
        }

        public async Task<ReadEmployeeCardDto> Update(ReadEmployeeCardDto employeeCard)
        {
            return await _employeeCardRepository.UpdateAsync(employeeCard);
        }
    }
}
