using MediatR;
using MetaPoc.Infrastructure.Data.Query.Interfaces.v1;
using System.Threading;
using System.Threading.Tasks;

namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.InterestRate
{
    public class InterestRateQueryHandler : IRequestHandler<InterestRateQuery, InterestRateQueryResponse>
    {
        private readonly IInterestRateQueryRepository _interestRateQueryRepository;

        public InterestRateQueryHandler(IInterestRateQueryRepository interestRateQueryRepository)
        {
            _interestRateQueryRepository = interestRateQueryRepository;
        }

        public async Task<InterestRateQueryResponse> Handle(InterestRateQuery request, CancellationToken cancellationToken)
        {
            return new InterestRateQueryResponse(await _interestRateQueryRepository.GetInterestRateAsync());
        }
    }
}