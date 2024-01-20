using CommunityTrainingAPI.Filter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CommunityTrainingAPI.Dtos;
using CommunityTrainingAPI.Filter;
using CommunityTrainingAPI.Models;
using CommunityTrainingAPI.Models.Authentication;
using CommunityTrainingAPI.Services;
using CommunityTrainingAPI.ViewModels;
using CommunityTrainingAPI.Services.Abrstractions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CommunityTraining.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class ResultsTableController : ControllerBase
    {
        private readonly IResultsTableService _resultsTableService;
        private readonly ILogger<ResultsTableController> _logger;

        public ResultsTableController(IResultsTableService service, ILogger<ResultsTableController> logger)
        {
            _resultsTableService = service;
            _logger = logger;
        }

        // GET: api/<ResultsTableController>
        [HttpGet("resultstables")]
        public async Task<IEnumerable<ResultsTableRowVM>> GetAll([FromQuery] GenericQueryOptions<CommunityTrainingFilter> option)
        {
            //throw new Exception("Test exception");

            _logger.LogInformation("GetAll called.");

            var res = await _resultsTableService.GetAllResultsTablesAsync(option);

            return res;
        }

        // GET api/<ResultsTablesController>/5
        [HttpGet("resultstables/{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            _logger.LogInformation($"GetById with id={id} called.");

            var r = await _resultsTableService.GetResultsTableByIdAsync(id);

            if (r == null)
            {
                return NotFound();
            }

            return Ok(r);
        }

        // POST api/<ResultsTablesController>
        [HttpPost("trainingplans/{trainingPlanId}/resultstables")]
        public async Task<IActionResult> Post(int trainingPlanId, [FromBody] NewResultsTableDTO resultsTable)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);

            _logger.LogInformation($"Post called.");

            var createdResultsTable = await _resultsTableService.CreateResultsTableAsync(trainingPlanId, resultsTable);
            if (createdResultsTable == null)
                return NotFound();

            _logger.LogInformation($"new resultsTable with name={resultsTable.Name} added to database.");

            return CreatedAtAction(nameof(GetById), new { Id = createdResultsTable.Id }, createdResultsTable);
        }

        // PUT api/<ResultsTablesController>/5
        [HttpPut("resultstables/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateResultsTableDTO resultsTable)
        {
            _logger.LogInformation($"Put called.");
            return await _resultsTableService.UpdateResultsTableAsync(id, resultsTable)
                ? NoContent()
                : NotFound();
        }

        // DELETE api/<ResultsTablesController>/5
        [HttpDelete("resultstables/{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            _logger.LogInformation($"Post called. It tries to delete the resultsTable with id={id}");
            //HttpContext.User.Claims
            return await _resultsTableService.DeleteResultsTableAsync(id)
                ? NoContent()
                : NotFound();
        }
    }
}
