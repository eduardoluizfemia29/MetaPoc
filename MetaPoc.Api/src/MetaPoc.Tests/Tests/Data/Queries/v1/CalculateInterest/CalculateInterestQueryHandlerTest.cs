using FluentAssertions;
using MetaPoc.Infrastructure.Data.Query.Interfaces.v1;
using MetaPoc.Infrastructure.Data.Query.Queries.v1.CalculateInterest;
using MetaPoc.Tests.Mocks.Contracts;
using NSubstitute;
using System.Threading.Tasks;
using Xunit;

namespace MetaPoc.Tests.Tests.Data.Queries.v1.CalculateInterest
{
    public class CalculateInterestQueryHandlerTest
    {
        public CalculateInterestQueryHandler GetHandler(
                IInterestRateQueryRepository repository = null
            )
        {
            repository ??= Substitute.For<IInterestRateQueryRepository>();

            return new CalculateInterestQueryHandler(repository);
        }

        [Fact(DisplayName = "Should Be Success When Call Method Handle With Valid Values")]
        public async Task ShouldBeSuccessWhenCallMethodHandleWithValidValues()
        {
            var repository = InterestRateQueryRepositoryMock.GetValidInstance();
            var handler = GetHandler(repository: repository);
            var result = await handler.Handle(new CalculateInterestQuery(100, 5), default);

            result.FinalValue.Should().Be("105,10");
        }

        [Fact(DisplayName = "Should Be Error When Call Method Handle With Invalid Values")]
        public async Task ShouldBeErrorWhenCallMethodHandleWithInvalidValues()
        {
            var repository = InterestRateQueryRepositoryMock.GetValidInstance();
            var handler = GetHandler(repository: repository);
            var result = await handler.Handle(null, default);

            result.Should().Be(null);
        }
    }
}