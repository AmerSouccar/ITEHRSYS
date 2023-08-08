using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Convictions.Services
{
    public class ConvictionDomainService : IConvictionDomainService
    {
        private readonly IRepository<Conviction, Guid> _convictionRepository;

        public ConvictionDomainService(IRepository<Conviction, Guid> convictionRepository)
        {
            _convictionRepository = convictionRepository;
        }

        public async Task Delete(Guid id)
        {
            await _convictionRepository.DeleteAsync(id);
        }

        public IQueryable<Conviction> GetAll()
        {
            return _convictionRepository.GetAllIncluding(x => x.Attachments);
        }

        public async Task<Conviction> GetbyId(Guid id)
        {
            return _convictionRepository.GetAllIncluding(x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Conviction> Insert(Conviction conviction)
        {
            return await _convictionRepository.InsertAsync(conviction);
        }

        public async Task<Conviction> Update(Conviction conviction)
        {
            return await _convictionRepository.UpdateAsync(conviction);
        }
    }
}
