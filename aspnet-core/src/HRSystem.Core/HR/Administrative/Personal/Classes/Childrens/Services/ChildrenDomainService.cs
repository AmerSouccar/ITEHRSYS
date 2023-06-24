using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Childrens.Services
{
    public class ChildrenDomainService : IChildrenDomainService
    {
        private readonly IRepository<Children, Guid> _childrenRepository;

        public ChildrenDomainService(IRepository<Children, Guid> childrenRepository)
        {
            _childrenRepository = childrenRepository;
        }

        public async Task Delete(Guid id)
        {
            await _childrenRepository.DeleteAsync(id);

        }

        public async Task<List<Children>> GetAll()
        {
            return _childrenRepository.GetAllIncluding(x => x.PlaceofBirth, x => x.Spouse, x => x.Nationality,x => x.Attachments).ToList();
        }

        public async Task<Children> GetbyId(Guid id)
        {
            return _childrenRepository.GetAllIncluding(x => x.PlaceofBirth, x => x.Spouse, x => x.Nationality, x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Children> Insert(Children children)
        {
            return await _childrenRepository.InsertAsync(children);
        }

        public async Task<Children> Update(Children children)
        {
            return await _childrenRepository.UpdateAsync(children);
        }
    }
}
