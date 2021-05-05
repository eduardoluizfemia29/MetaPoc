using MetaPoc.Infrastructure.Data.Query.Interfaces.v1;
using NSubstitute;

namespace MetaPoc.Tests.Mocks.Contracts
{
    public static class InterestRateQueryRepositoryMock
    {
        public static IInterestRateQueryRepository GetValidInstance()
        {
            return Substitute.For<IInterestRateQueryRepository>()
                .GetInterestRate();
        }

        public static IInterestRateQueryRepository GetInterestRate(this IInterestRateQueryRepository repository)
        {
            repository.GetInterestRateAsync().Returns(0.01);

            return repository;
        }
    }
}