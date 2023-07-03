using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Convictions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Convictions.Services
{
    public interface IConvictionAppService :IApplicationService
    {
        public Task<List<ReadConvictionDto>> GetAll();
        public Task<ReadConvictionDto> GetbyId(Guid id);
        public Task<InsertConvictionDto> Insert(InsertConvictionDto conviction);
        public Task<UpdateConvictionDto> Update(UpdateConvictionDto conviction);
        public Task Delete(Guid id);
    }
}
