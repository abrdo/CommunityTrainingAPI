using AutoMapper;
using CommunityTrainingAPI.Dtos;
using CommunityTrainingAPI.Filter;
using CommunityTrainingAPI.Models;
using CommunityTrainingAPI.Services.Abrstractions;
using CommunityTrainingAPI.ViewModels;
using System.Linq.Expressions;

namespace CommunityTrainingAPI.Services.Implementations
{
    public class ResultsTableService : IResultsTableService
    {
        private readonly CommunityTrainingContext _context;
        private readonly IMapper _mapper;
        public ResultsTableService(CommunityTrainingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<ResultsTableVM> CreateResultsTableAsync(int id, NewResultsTableDTO newTrainigPlanDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteResultsTableAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultsTableRowVM>> GetAllResultsTablesAsync(GenericQueryOptions<CommunityTrainingFilter> options)
        {
            throw new NotImplementedException();
        }

        public Task<ResultsTableVM> GetResultsTableByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultsTableRowVM>> GetResultsTablesWhereAsync(Expression<Func<ResultsTable, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateResultsTableAsync(int idn, UpdateResultsTableDTO updateTrainigPlanDTO)
        {
            throw new NotImplementedException();
        }
    }
}
