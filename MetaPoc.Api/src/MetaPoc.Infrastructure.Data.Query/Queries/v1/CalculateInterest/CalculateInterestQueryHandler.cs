using MediatR;
using MetaPoc.Infrastructure.Data.Query.Interfaces.v1;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MetaPoc.Infrastructure.Data.Query.Queries.v1.CalculateInterest
{
    public class CalculateInterestQueryHandler : IRequestHandler<CalculateInterestQuery, CalculateInterestQueryResponse>
    {
        private readonly IInterestRateQueryRepository _interestRateQueryRepository;

        public CalculateInterestQueryHandler(IInterestRateQueryRepository interestRateQueryRepository)
        {
            _interestRateQueryRepository = interestRateQueryRepository;
        }

        public async Task<CalculateInterestQueryResponse> Handle(CalculateInterestQuery request, CancellationToken cancellationToken)
        {

            if (request == null) return null;

            var finalValue = await ProcessCalculation(request);

            return new CalculateInterestQueryResponse(finalValue.ToString());
        }

        private async Task<decimal> ProcessCalculation(CalculateInterestQuery request)
        {
            var fees = await _interestRateQueryRepository.GetInterestRateAsync();

            var calculation = Math.Pow((1 + fees), request.Month);

            var finalValue = Math.Round(request.InitialValue * (decimal)calculation, 2);
            return finalValue;
        }
    }
}