using MediatR;

namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.CalculaJuros
{
    public class CalculaJurosQuery : IRequest<CalculaJurosQueryResponse>
    {
        public CalculaJurosQuery(decimal valorInicial, int meses)
        {
            ValorInicial = valorInicial;
            Meses = meses;
        }

        public decimal ValorInicial { get; set; }
        public int Meses { get; set; }
    }
}