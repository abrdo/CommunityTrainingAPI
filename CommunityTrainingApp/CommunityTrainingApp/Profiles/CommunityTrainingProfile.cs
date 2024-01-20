using AutoMapper;
using CommunityTrainingAPI.Dtos;
using CommunityTrainingAPI.Models;
using CommunityTrainingAPI.ViewModels;

namespace CommunityTrainingAPI.Profiles
{
    public class CommunityTrainingProfile : Profile
    {
        public CommunityTrainingProfile()
        {
            CreateMap<NewTrainingPlanDTO, TrainingPlan>();
            CreateMap<UpdateTrainingPlanDTO, TrainingPlan>();
            CreateMap<TrainingPlan, TrainingPlanRowVM>();

            CreateMap<NewResultsTableDTO, ResultsTable>();
            CreateMap<UpdateResultsTableDTO, ResultsTable>();
            CreateMap<ResultsTable, ResultsTableRowVM>();
        }
    }
}
