using MediatR;
using MetaPoc.Infrastructure.Data.Query.Queries.v1.CalculaJuros;
using MetaPoc.Infrastructure.Data.Query.Queries.v1.TaxaJuros;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MetaPoc.Api.Controller
{
    [Route("api/v1/juros")]
    [ApiController]
    public class MetaController : ControllerBase
    {
        public readonly IMediator _mediator;

        public MetaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("taxaJuros")]
        public async Task<IActionResult> GetTaxaJurosAsync()
        {
            return Ok(await _mediator.Send(new TaxaJurosQuery()).ConfigureAwait(false));
        }

        [HttpGet("calculaJuros")]
        public async Task<IActionResult> CalculaJurosAsync(decimal valorInicial, int meses)
        {
            return Ok(await _mediator.Send(new CalculaJurosQuery(valorInicial, meses)).ConfigureAwait(false));
        }
    }
}