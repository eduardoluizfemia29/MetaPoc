using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.Code
{
    public class CodeQueryHandler : IRequestHandler<CodeQuery, CodeQueryResponse>
    {
        public async Task<CodeQueryResponse> Handle(CodeQuery request, CancellationToken cancellationToken)
        {
            return new CodeQueryResponse("https://github.com/eduardoluizfemia29/MetaPoc");
        }
    }
}