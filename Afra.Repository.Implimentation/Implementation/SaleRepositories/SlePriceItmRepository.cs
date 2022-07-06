using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SlePriceItmRepository : Repository<SlePriceItm> , ISlePriceItmRepository
    {
        public SlePriceItmRepository(DataContext context) : base(context)
        {
        }
    }
}
