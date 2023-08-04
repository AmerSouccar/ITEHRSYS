using Abp.Domain.Repositories;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Services
{
    public class NodeDomainService : INodeDomainService
    {
        private readonly IRepository<Node,Guid> _nodeRepository;

        public NodeDomainService(IRepository<Node, Guid> nodeRepository)
        {
            _nodeRepository = nodeRepository;
        }

        public async Task Delete(Guid id)
        {
            await _nodeRepository.DeleteAsync(id);
        }

        public IQueryable<Node> GetAll()
        {
          return _nodeRepository.GetAllIncluding(x => x.Childrens,x => x.JobDescriptions,x => x.Parent);
        }

        public async Task<Node> GetbyId(Guid id)
        {
            var node = await _nodeRepository.GetAsync(id);
            if(node != null)
            {
                await _nodeRepository.EnsureCollectionLoadedAsync(node, x => x.Childrens);
                await _nodeRepository.EnsureCollectionLoadedAsync(node, x => x.JobDescriptions);
                await _nodeRepository.EnsurePropertyLoadedAsync(node, x => x.Parent);
            }
            return node;
        }

        public async Task<Node> Insert(Node bank)
        {
            return await _nodeRepository.InsertAsync(bank);
        }

        public async Task<Node> Update(Node bank)
        {
            return await _nodeRepository.UpdateAsync(bank);
        }
    }
}
