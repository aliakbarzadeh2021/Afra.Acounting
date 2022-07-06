using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ShopGiftCardRepository : Repository<ShopGiftCard> , IShopGiftCardRepository
    {
        public ShopGiftCardRepository(DataContext context) : base(context)
        {
        }
    }
}
