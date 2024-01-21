using AutoMapper;
using CommunityTrainingAPI.Dtos;
using CommunityTrainingAPI.Filter;
using CommunityTrainingAPI.Models;
using CommunityTrainingAPI.ViewModels;
using CommunityTrainingAPI.Models;
using CommunityTrainingAPI.Services.Abrstractions;
using System.Linq.Expressions;

namespace CommunityTrainingAPI.Services.Implementations
{
    public class TrainingPlanService : ITrainingPlanService
    {
        private readonly CommunityTrainingContext _context;
        private readonly IMapper _mapper;
        public TrainingPlanService(CommunityTrainingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<TrainingPlanVM> CreateTrainingPlanAsync(int id, NewTrainingPlanDTO newTrainigPlanDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTrainingPlanAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TrainingPlanRowVM>> GetAllTrainingPlansAsync(GenericQueryOptions<CommunityTrainingFilter> options)
        {
            throw new NotImplementedException();
        }

        public Task<TrainingPlanVM> GetTrainingPlanByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TrainingPlanRowVM>> GetTrainingPlansWhereAsync(Expression<Func<TrainingPlan, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTrainingPlanAsync(int idn, UpdateTrainingPlanDTO updateTrainigPlanDTO)
        {
            throw new NotImplementedException();
        }
    }
}
