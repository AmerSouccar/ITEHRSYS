using HRSystem.HR.Operational.EmployeeServices.Classes.Resignations.Dto;
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

        public async Task<List<ReadResignationDto>> GetAll()
        {
            return ObjectMapper.Map<List<ReadResignationDto>>(await _resignationdomainservice.GetAll());
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
