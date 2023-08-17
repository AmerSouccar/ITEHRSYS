using Abp.Application.Services.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Assignments.Dto;
using HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Services
{
    public class ResignationAppService : HRSystemAppServiceBase, IResignationAppService
    {
        private readonly IResignationdomainService _resignationdomainservice;

        public ResignationAppService(IResignationdomainService resignationdomainservice)
        {
            _resignationdomainservice = resignationdomainservice;
        }

        public async Task Delete(Guid id)
        {
            await _resignationdomainservice.Delete(id);
        }

        public PagedResultDto<ReadResignationDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var resignitions = _resignationdomainservice.GetAll();
            int total = resignitions.Count();
            resignitions = resignitions.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadResignationDto>>(resignitions.ToList());
            return new PagedResultDto<ReadResignationDto>(total, list);
        }

        public async Task<ReadResignationDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadResignationDto>(await _resignationdomainservice.GetbyId(id));
        }

        public async Task<InsertResignationDto> Insert(InsertResignationDto resignation)
        {
            return ObjectMapper.Map<InsertResignationDto>(await _resignationdomainservice.Insert(ObjectMapper.Map<Resignation>(resignation)));
        }

        public async Task<UpdateResignationDto> Update(UpdateResignationDto resignation)
        {
            return ObjectMapper.Map<UpdateResignationDto>(await _resignationdomainservice.Update(ObjectMapper.Map<Resignation>(resignation)));

        }
    }
}
