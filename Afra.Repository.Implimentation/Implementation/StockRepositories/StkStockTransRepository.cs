using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class StkStockTransRepository : Repository<StkStockTrans> , IStkStockTransRepository
    {
        public StkStockTransRepository(DataContext context) : base(context)
        {
        }
    }
}
