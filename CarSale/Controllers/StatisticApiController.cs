using CarSale.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CarSale.Controllers
{
    [Route("api/statistic")]
    [ApiController]
    public class StatisticApiController : ControllerBase
    {
        private readonly IStatisticService statisticService;

        public StatisticApiController(IStatisticService _statisticService)
        {
            statisticService = _statisticService;
        }

        [HttpGet]
        public async Task<IActionResult> GetStatistic()
        {
            var result = await statisticService.TotalAsync();

            return Ok(result);
        }
    }
}
