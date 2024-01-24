using AutoMapper;
using AutoMapper.QueryableExtensions;
using CommunityTrainingAPI.Dtos;
using CommunityTrainingAPI.Filter;
using CommunityTrainingAPI.Models;
using CommunityTrainingAPI.Services.Abrstractions;
using CommunityTrainingAPI.ViewModels;
using Microsoft.EntityFrameworkCore;
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
        public async Task<ResultsTableVM> CreateResultsTableAsync(int trainingPlanId, NewResultsTableDTO x)
        {
            var m = _mapper.Map<ResultsTable>(x);

            var trainingPlan = await _context.TrainingPlans.FindAsync(trainingPlanId);
            if (trainingPlan == null)
                return null;

            // Set the foreign key id
            m.TrainingPlanId = trainingPlanId;


            _context.ResultsTables.Add(m);
            await _context.SaveChangesAsync();

            return _mapper.Map<ResultsTableVM>(m);
        }

        public async Task<bool> DeleteResultsTableAsync(int id)
        {
            var rt = await _context.ResultsTables.FindAsync(id);
            if (rt == null)
                return false;

            _context.ResultsTables.Remove(rt);

            //  1. Get the recipebook by a separate query
            var recipeBook = await _context.TrainingPlans.FindAsync(rt.TrainingPlanId);
            //recipeBook.ResultsTablesNumber--;

            //  2. Explicitely load navigation property
            //await _context
            //    .Entry(r)
            //    .Reference(x => x.TrainingPlan)
            //    .LoadAsync();

            //  3. Using lazy loading

            //_context.Entry(new ResultsTable { Id = id }).State = EntityState.Deleted;

            var n = await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<ResultsTableRowVM>> GetAllResultsTablesAsync(GenericQueryOptions<CommunityTrainingFilter> option)
        {
            var q = _context.ResultsTables as IQueryable<ResultsTable>;
            if (!String.IsNullOrEmpty(option.Filter?.NameTerm))
            {
                q = q.Where(x => x.Name.Contains(option.Filter.NameTerm));
            }
            if (option.Filter?.MinRating != null)
            {
                q = q.Where(x => x.RuninngResult >= option.Filter.MinRating);
            }
            if (option.Filter?.MaxRating != null)
            {
                q = q.Where(x => x.RuninngResult <= option.Filter.MaxRating);
            }

            q = option.SortOrder == SortOrder.Ascending
                ? q.OrderBy(x => x.Name)
                : q.OrderByDescending(x => x.Name);

            return await q
                .Skip((option.Page - 1) * option.PageSize)
                .Take(option.PageSize)
                //.Select(x => new ResultsTableRowVM
                //{
                //   Id = x.Id,
                //   Name = x.Name,
                //   RatingsAvg = x.RatingsAvg,
                //   trainingPlanName = x.TrainingPlan.Name
                //})
                .ProjectTo<ResultsTableRowVM>(_mapper.ConfigurationProvider)
                .ToListAsync();

        }

        public async Task<ResultsTableVM> GetResultsTableByIdAsync(int id)
        {
            return await _context
                .ResultsTables
                .Where(x => x.Id == id)
                .Select(x => _mapper.Map<ResultsTableVM>(x))
                .SingleOrDefaultAsync();
        }

        public async Task<List<ResultsTableRowVM>> GetResultsTablesWhereAsync(Expression<Func<ResultsTable, bool>> predicate)
        {
            return await _context
                .ResultsTables
                .Where(predicate)
                .Select(x => _mapper.Map<ResultsTableRowVM>(x))
                .ToListAsync();
        }

        public async Task<bool> UpdateResultsTableAsync(int id, UpdateResultsTableDTO rtNewDto)
        {
            var rtToUpdate = _context
                .ResultsTables
                .SingleOrDefault(x => x.Id == id);
            if (rtToUpdate == null)
            {
                return false;
            }
            _mapper.Map(rtNewDto, rtToUpdate);

            _context.Entry(rtToUpdate).State = EntityState.Modified;
            var n = await _context.SaveChangesAsync();
            return n == 1;
        }
    }
}
