namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.CalculaJuros
{
    public class CalculaJurosQueryResponse
    {
        public CalculaJurosQueryResponse(string valorFinal)
        {
            ValorFinal = valorFinal;
        }

        public string ValorFinal { get; set; }
    }
}