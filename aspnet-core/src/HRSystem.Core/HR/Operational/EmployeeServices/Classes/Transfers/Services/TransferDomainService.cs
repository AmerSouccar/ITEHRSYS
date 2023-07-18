using Abp.Domain.Repositories;
using HRSystem.HR.Operational.EmployeeServices.Classes.Resignations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Transfers.Services
{
    public class TransferDomainService : ITransferDomainService
    {
        private readonly IRepository<Transfer,Guid> _transferRepository;

        public TransferDomainService(IRepository<Transfer, Guid> transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public async Task Delete(Guid id)
        {
            await _transferRepository.DeleteAsync(id);
        }

        public async Task<List<Transfer>> GetAll()
        {
            return _transferRepository.GetAllIncluding(x => x.DestinationJobTitle, x => x.DestinationPosition).ToList();
        }

        public async Task<Transfer> GetbyId(Guid id)
        {
            Transfer transfer = await _transferRepository.GetAsync(id);
            if (transfer != null)
            {
                await _transferRepository.EnsurePropertyLoadedAsync(transfer, x => x.DestinationJobTitle);
                await _transferRepository.EnsurePropertyLoadedAsync(transfer, x => x.DestinationPosition);

            }
            return transfer;
         }

        public async Task<Transfer> Insert(Transfer transfer)
        {
            return await _transferRepository.InsertAsync(transfer);
        }

        public async Task<Transfer> Update(Transfer transfer)
        {
            return await _transferRepository.UpdateAsync(transfer);

        }
    }
}
