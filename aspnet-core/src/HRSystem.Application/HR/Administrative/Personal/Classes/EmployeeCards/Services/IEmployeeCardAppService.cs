using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.EmployeeCards.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.EmployeeCards.Services
{
    public interface IEmployeeCardAppService : IApplicationService
    {
        public PagedResultDto<ReadEmployeeCardDto> GetAll(PagedGeneralResultRequestDto input);
        public Task<ReadEmployeeCardDto> GetbyId(Guid id);
        public Task<UpdateEmployeeCardDto> GetForEdit(Guid id);
        public Task<UpdateEmployeeCardDto> Update(UpdateEmployeeCardDto employee);
        //public Task Delete(Guid id);
    }
}
