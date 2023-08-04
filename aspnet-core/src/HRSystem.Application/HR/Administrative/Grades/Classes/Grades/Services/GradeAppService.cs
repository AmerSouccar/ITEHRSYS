using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Grades.Classes.Grades.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Banks.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Grades.Classes.Grades.Services
{
    public class GradeAppService : HRSystemAppServiceBase, IGradeAppService
    {
        private readonly IGradeDomainService _gradeDomainService;

        public GradeAppService(IGradeDomainService gradeDomainService)
        {
            _gradeDomainService = gradeDomainService;
        }

        public async Task Delete(Guid id)
        {
           await _gradeDomainService.Delete(id);
        }

        public PagedResultDto<ReadGradeDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var grades = _gradeDomainService.GetAll();
            int total = grades.Count();
            grades = grades.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadGradeDto>>(grades.ToList());
            return new PagedResultDto<ReadGradeDto>(total, list);
        }

        public async Task<ReadGradeDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadGradeDto>(await _gradeDomainService.GetbyId(id));
        }

        public async Task<InsertGradeDto> Insert(InsertGradeDto grade)
        {
            return ObjectMapper.Map<InsertGradeDto>(await _gradeDomainService.Insert(ObjectMapper.Map<Grade>(grade)));
        }

        public async Task<UpdateGradeDto> Update(UpdateGradeDto grade)
        {
            return ObjectMapper.Map<UpdateGradeDto>(await _gradeDomainService.Update(ObjectMapper.Map<Grade>(grade)));

        }
    }
}
