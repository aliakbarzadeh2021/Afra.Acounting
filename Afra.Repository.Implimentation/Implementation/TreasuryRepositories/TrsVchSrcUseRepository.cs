using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsVchSrcUseRepository : Repository<TrsVchSrcUse> , ITrsVchSrcUseRepository
    {
        public TrsVchSrcUseRepository(DataContext context) : base(context)
        {
        }
    }
}
