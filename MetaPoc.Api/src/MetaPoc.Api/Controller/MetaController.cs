using MediatR;
using MetaPoc.Infrastructure.Data.Query.Queries.v1.CalculateInterest;
using MetaPoc.Infrastructure.Data.Query.Queries.v1.InterestRate;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MetaPoc.Api.Controller
{
    [Route("api/v1/fees")]
    [ApiController]
    public class MetaController : ControllerBase
    {
        public readonly IMediator _mediator;

        public MetaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("interestrate")]
        public async Task<IActionResult> GetInterestRateAsync()
        {
            return Ok(await _mediator.Send(new InterestRateQuery()));
        }

        [HttpGet("calculateinterest")]
        public async Task<IActionResult> CalculateInterestAsync(decimal initialValue, int month)
        {
            return Ok(await _mediator.Send(new CalculateInterestQuery(initialValue, month)));
        }
    }
}