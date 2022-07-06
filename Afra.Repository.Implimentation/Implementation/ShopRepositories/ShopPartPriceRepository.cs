using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ShopPartPriceRepository : Repository<ShopPartPrice> , IShopPartPriceRepository
    {
        public ShopPartPriceRepository(DataContext context) : base(context)
        {
        }
    }
}
