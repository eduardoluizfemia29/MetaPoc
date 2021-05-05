namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.TaxaJuros
{
    public class TaxaJurosQueryResponse
    {
        public TaxaJurosQueryResponse(double juros)
        {
            Juros = juros;
        }

        public double Juros { get; set; }
    }
}