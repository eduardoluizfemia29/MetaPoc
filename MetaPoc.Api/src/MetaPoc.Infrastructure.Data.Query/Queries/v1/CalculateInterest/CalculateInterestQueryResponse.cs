namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.CalculateInterest
{
    public class CalculateInterestQueryResponse
    {
        public CalculateInterestQueryResponse(string finalValue)
        {
            FinalValue = finalValue;
        }

        public string FinalValue { get; set; }
    }
}