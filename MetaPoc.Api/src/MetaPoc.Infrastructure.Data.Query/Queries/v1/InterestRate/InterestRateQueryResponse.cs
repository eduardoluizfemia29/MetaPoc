namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.InterestRate
{
    public class InterestRateQueryResponse
    {
        public InterestRateQueryResponse(double fees)
        {
            Fees = fees;
        }

        public double Fees { get; set; }
    }
}