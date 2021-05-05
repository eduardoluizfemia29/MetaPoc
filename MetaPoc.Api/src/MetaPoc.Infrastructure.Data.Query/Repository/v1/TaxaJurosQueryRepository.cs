using MetaPoc.Infrastructure.Data.Query.Interfaces.v1;
using System.Threading.Tasks;

namespace MetaPoc.Infrastructure.Data.Query.Repository.v1
{
    public class TaxaJurosQueryRepository : ITaxaJurosQueryRepository
    {
        public async Task<double> GetTaxaJuros()
        {
            return 0.01;
        }
    }
}