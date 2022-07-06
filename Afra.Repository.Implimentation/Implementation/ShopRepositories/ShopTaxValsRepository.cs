using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ShopTaxValsRepository : Repository<ShopTaxVals> , IShopTaxValsRepository
    {
        public ShopTaxValsRepository(DataContext context) : base(context)
        {
        }
    }
}
