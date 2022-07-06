using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class StkStockersRepository : Repository<StkStockers> , IStkStockersRepository
    {
        public StkStockersRepository(DataContext context) : base(context)
        {
        }
    }
}
