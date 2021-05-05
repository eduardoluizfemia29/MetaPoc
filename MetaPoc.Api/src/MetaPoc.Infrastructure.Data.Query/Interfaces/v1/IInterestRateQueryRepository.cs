using System.Threading.Tasks;

namespace MetaPoc.Infrastructure.Data.Query.Interfaces.v1
{
    public interface IInterestRateQueryRepository
    {
        Task<double> GetInterestRateAsync();
    }
}