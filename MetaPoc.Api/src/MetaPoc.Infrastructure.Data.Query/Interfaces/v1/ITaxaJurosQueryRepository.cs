using System.Threading.Tasks;

namespace MetaPoc.Infrastructure.Data.Query.Interfaces.v1
{
    public interface ITaxaJurosQueryRepository
    {
        Task<double> GetTaxaJuros();
    }
}