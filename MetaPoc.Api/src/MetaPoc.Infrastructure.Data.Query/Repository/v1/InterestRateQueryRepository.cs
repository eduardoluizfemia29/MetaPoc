using MetaPoc.Infrastructure.Data.Query.Interfaces.v1;
using System.Threading.Tasks;

namespace MetaPoc.Infrastructure.Data.Query.Repository.v1
{
    public class InterestRateQueryRepository : IInterestRateQueryRepository
    {
        public async Task<double> GetInterestRateAsync()
        {
            return 0.01;
        }
    }
}