using MediatR;

namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.CalculateInterest
{
    public class CalculateInterestQuery : IRequest<CalculateInterestQueryResponse>
    {
        public CalculateInterestQuery(decimal initialValue, int time)
        {
            InitialValue = initialValue;
            Time = time;
        }

        public decimal InitialValue { get; set; }
        public int Time { get; set; }
    }
}