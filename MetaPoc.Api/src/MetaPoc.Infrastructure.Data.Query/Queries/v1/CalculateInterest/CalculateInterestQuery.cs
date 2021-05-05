using MediatR;

namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.CalculateInterest
{
    public class CalculateInterestQuery : IRequest<CalculateInterestQueryResponse>
    {
        public CalculateInterestQuery(decimal initialValue, int month)
        {
            InitialValue = initialValue;
            Month = month;
        }

        public decimal InitialValue { get; set; }
        public int Month { get; set; }
    }
}