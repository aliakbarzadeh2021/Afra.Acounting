using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsVchItmRelRepository : Repository<TrsVchItmRel> , ITrsVchItmRelRepository
    {
        public TrsVchItmRelRepository(DataContext context) : base(context)
        {
        }
    }
}
