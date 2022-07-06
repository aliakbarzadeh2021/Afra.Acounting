using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ShopsRepository : Repository<Shops> , IShopsRepository
    {
        public ShopsRepository(DataContext context) : base(context)
        {
        }
    }
}
