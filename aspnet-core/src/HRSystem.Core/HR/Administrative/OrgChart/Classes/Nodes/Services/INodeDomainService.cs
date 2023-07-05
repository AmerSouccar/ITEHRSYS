using Abp.Domain.Services;
using HRSystem.HR.Administrative.Personal.Classes.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.OrgChart.Classes.Nodes.Services
{
    public interface INodeDomainService : IDomainService
    {
        public Task<List<Node>> GetAll();
        public Task<Node> GetbyId(Guid id);
        public Task<Node> Insert(Node bank);
        public Task<Node> Update(Node bank);
        public Task Delete(Guid id);
    }
}
