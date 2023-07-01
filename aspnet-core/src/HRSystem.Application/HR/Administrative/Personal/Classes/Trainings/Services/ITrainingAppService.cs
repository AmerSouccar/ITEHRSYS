using Abp.Application.Services;
using HRSystem.HR.Administrative.Personal.Classes.Trainings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Trainings.Services
{
    public interface ITrainingAppService : IApplicationService
    {
        public Task<List<ReadTrainingDto>> GetAll();
        public Task<ReadTrainingDto> GetbyId(Guid id);
        public Task<InsertTrainingDto> Insert(InsertTrainingDto training);
        public Task<UpdateTrainingDto> Update(UpdateTrainingDto training);
        public Task Delete(Guid id);
    }
}
