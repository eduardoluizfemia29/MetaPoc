using MediatR;
using MetaPoc.Infrastructure.Data.Query.Interfaces.v1;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.CalculaJuros
{
    public class CalculaJurosQueryHandler : IRequestHandler<CalculaJurosQuery, CalculaJurosQueryResponse>
    {
        private readonly ITaxaJurosQueryRepository _taxaJurosQueryRepository;

        public CalculaJurosQueryHandler(ITaxaJurosQueryRepository taxaJurosQueryRepository)
        {
            _taxaJurosQueryRepository = taxaJurosQueryRepository;
        }

        public async Task<CalculaJurosQueryResponse> Handle(CalculaJurosQuery request, CancellationToken cancellationToken)
        {
            var juros = await _taxaJurosQueryRepository.GetTaxaJuros();

            var calculo = Math.Pow((1 + juros), request.Meses);

            var valorFinal = Math.Round(request.ValorInicial * (decimal)calculo, 2);

            return new CalculaJurosQueryResponse(valorFinal.ToString());
        }
    }
}