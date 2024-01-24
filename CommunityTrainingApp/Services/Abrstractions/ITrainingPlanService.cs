using CommunityTrainingAPI.Dtos;
using CommunityTrainingAPI.Filter;
using CommunityTrainingAPI.ViewModels;
using CommunityTrainingAPI.Models;
using System.Linq.Expressions;

namespace CommunityTrainingAPI.Services.Abrstractions
{
    public interface ITrainingPlanService
    {
        Task<TrainingPlanVM> CreateTrainingPlanAsync(int id, NewTrainingPlanDTO newTrainigPlanDTO);
        Task<bool> DeleteTrainingPlanAsync (int id);
        Task<List<TrainingPlanRowVM>> GetAllTrainingPlansAsync(GenericQueryOptions<CommunityTrainingFilter> options);
        Task<TrainingPlanVM> GetTrainingPlanByIdAsync(int id);
        Task<List<TrainingPlanRowVM>> GetTrainingPlansWhereAsync(Expression<Func<TrainingPlan, bool>> predicate);
        Task<bool> UpdateTrainingPlanAsync(int idn, UpdateTrainingPlanDTO updateTrainigPlanDTO);

    }
}
