using CommunityTrainingAPI.Dtos;
using CommunityTrainingAPI.Filter;
using CommunityTrainingAPI.Models;
using CommunityTrainingAPI.ViewModels;
using System.Linq.Expressions;

namespace CommunityTrainingAPI.Services.Abrstractions
{
    public interface IResultsTableService
    {
        Task<ResultsTableVM> CreateResultsTableAsync(int id, NewResultsTableDTO newTrainigPlanDTO);
        Task<bool> DeleteResultsTableAsync(int id);
        Task<List<ResultsTableRowVM>> GetAllResultsTablesAsync(GenericQueryOptions<CommunityTrainingFilter> options);
        Task<ResultsTableVM> GetResultsTableByIdAsync(int id);
        Task<List<ResultsTableRowVM>> GetResultsTablesWhereAsync(Expression<Func<ResultsTable, bool>> predicate);
        Task<bool> UpdateResultsTableAsync(int idn, UpdateResultsTableDTO updateTrainigPlanDTO);
    }
}
