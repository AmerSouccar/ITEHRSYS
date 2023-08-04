using Abp.Application.Services.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Educations.Dto;
using HRSystem.HR.Administrative.Personal.Classes.Trainings.Dto;
using HRSystem.HR.PaginationDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Trainings.Services
{
    public class TrainingAppService : HRSystemAppServiceBase, ITrainingAppService
    {
        private readonly ITrainingDomainService _traningDomainservice;

        public TrainingAppService(ITrainingDomainService traningDomainservice)
        {
            _traningDomainservice = traningDomainservice;
        }

        public async Task Delete(Guid id)
        {
            await _traningDomainservice.Delete(id);
        }

        public PagedResultDto<ReadTrainingDto> GetAll(PagedGeneralResultRequestDto input)
        {
            var trainings = _traningDomainservice.GetAll();
            int total = trainings.Count();
            trainings = trainings.Skip(input.SkipCount).Take(input.MaxResultCount);

            var list = ObjectMapper.Map<List<ReadTrainingDto>>(trainings.ToList());
            return new PagedResultDto<ReadTrainingDto>(total, list);
        }

        public async Task<ReadTrainingDto> GetbyId(Guid id)
        {
            return ObjectMapper.Map<ReadTrainingDto>(await _traningDomainservice.GetbyId(id));
        }

        public async Task<InsertTrainingDto> Insert(InsertTrainingDto training)
        {
            return ObjectMapper.Map<InsertTrainingDto>(await _traningDomainservice.Insert(ObjectMapper.Map<Training>(training)));
        }

        public async Task<UpdateTrainingDto> Update(UpdateTrainingDto training)
        {
            return ObjectMapper.Map<UpdateTrainingDto>(await _traningDomainservice.Update(ObjectMapper.Map<Training>(training)));
        }
    }
}
