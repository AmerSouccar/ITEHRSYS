using HRSystem.HR.Administrative.Personal.Indexes.DriverLicenseTypes.Dto;
using HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Indexes.EducationIndexes.EducationMajors.Services
{
    public class EducationMajorAppService : HRSystemAppServiceBase, IEducationMajorAppService
    {
        private readonly IEducationMajorDomainService _educationMajorDomainService;

        public EducationMajorAppService(IEducationMajorDomainService educationMajorDomainService)
        {
            _educationMajorDomainService = educationMajorDomainService;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _educationMajorDomainService.DeleteAsync(id);
        }

        public async Task<List<EducationMajorDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<EducationMajorDto>>(await _educationMajorDomainService.GetEducationMajorsAsync());

        }

        public async Task<EducationMajorDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<EducationMajorDto>(await _educationMajorDomainService.GetbyId(id));

        }

        public async Task<EducationMajorDto> InsertAsync(EducationMajorDto educationMajor)
        {
            return ObjectMapper.Map<EducationMajorDto>(await _educationMajorDomainService.InsertAsync(ObjectMapper.Map<EducationMajor>(educationMajor)));
        }

        public async Task<EducationMajorDto> UpdateAsync(EducationMajorDto educationMajor)
        {
            return ObjectMapper.Map<EducationMajorDto>(await _educationMajorDomainService.UpdateAsync(ObjectMapper.Map<EducationMajor>(educationMajor)));
        }
    }
}
