using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmPersMrgRepository : Repository<HrmPersMrg> , IHrmPersMrgRepository
    {
        public HrmPersMrgRepository(DataContext context) : base(context)
        {
        }
    }
}
