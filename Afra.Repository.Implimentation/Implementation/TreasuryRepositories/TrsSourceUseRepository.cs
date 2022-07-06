using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsSourceUseRepository : Repository<TrsSourceUse> , ITrsSourceUseRepository
    {
        public TrsSourceUseRepository(DataContext context) : base(context)
        {
        }
    }
}
