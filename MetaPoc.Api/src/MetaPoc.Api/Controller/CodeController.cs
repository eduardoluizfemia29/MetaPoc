using MediatR;
using MetaPoc.Infrastructure.Data.Query.Queries.v1.Code;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MetaPoc.Api.Controller
{
    [Route("api/v1/code")]
    [ApiController]
    public class CodeController : ControllerBase
    {
        public readonly IMediator _mediator;

        public CodeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("showmethecode")]
        public async Task<IActionResult> GetCodeAsynnc()
        {
            return Ok(await _mediator.Send(new CodeQuery()));
        }
    }
}