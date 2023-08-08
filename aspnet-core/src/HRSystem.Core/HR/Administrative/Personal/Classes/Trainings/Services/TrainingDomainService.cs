using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.HR.Administrative.Personal.Classes.Trainings.Services
{
    public class TrainingDomainService : ITrainingDomainService
    {
        private readonly IRepository<Training, Guid> _trainingRepository;

        public TrainingDomainService(IRepository<Training, Guid> trainingRepository)
        {
            _trainingRepository = trainingRepository;
        }

        public async Task Delete(Guid id)
        {
           await _trainingRepository.DeleteAsync(id);
        }

        public IQueryable<Training> GetAll()
        {
            return _trainingRepository.GetAllIncluding(x => x.Attachments);
        }

        public async Task<Training> GetbyId(Guid id)
        {
            return _trainingRepository.GetAllIncluding(x => x.Attachments).FirstOrDefault(x => x.Id == id);
        }

        public async Task<Training> Insert(Training training)
        {
           return await _trainingRepository.InsertAsync(training);
        }

        public async Task<Training> Update(Training training)
        {
            return await (_trainingRepository.UpdateAsync(training));
        }
    }
}
