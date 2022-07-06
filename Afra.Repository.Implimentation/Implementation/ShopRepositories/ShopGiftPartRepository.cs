using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ShopGiftPartRepository : Repository<ShopGiftPart> , IShopGiftPartRepository
    {
        public ShopGiftPartRepository(DataContext context) : base(context)
        {
        }
    }
}
