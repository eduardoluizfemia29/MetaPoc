using MediatR;
using MetaPoc.Infrastructure.Data.Query.Interfaces.v1;
using System.Threading;
using System.Threading.Tasks;

namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.TaxaJuros
{
    public class TaxaJurosQueryHandler : IRequestHandler<TaxaJurosQuery, TaxaJurosQueryResponse>
    {
        private readonly ITaxaJurosQueryRepository _taxaJurosQueryRepository;

        public TaxaJurosQueryHandler(ITaxaJurosQueryRepository taxaJurosQueryRepository)
        {
            _taxaJurosQueryRepository = taxaJurosQueryRepository;
        }

        public async Task<TaxaJurosQueryResponse> Handle(TaxaJurosQuery request, CancellationToken cancellationToken)
        {
            return new TaxaJurosQueryResponse(await _taxaJurosQueryRepository.GetTaxaJuros());
        }
    }
}