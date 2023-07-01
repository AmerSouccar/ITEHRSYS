using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Childrens.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Childrens.Services
{
    public interface IChildrenAppService : IApplicationService
    {
        public Task<List<ReadChildrenDto>> GetAll();
        public Task<ReadChildrenDto> GetbyId(Guid id);
        public Task<InsertChildrenDto> Insert(InsertChildrenDto children);
        public Task<UpdateChildrenDto> Update(UpdateChildrenDto children);
        public Task Delete(Guid id);
    }
}
