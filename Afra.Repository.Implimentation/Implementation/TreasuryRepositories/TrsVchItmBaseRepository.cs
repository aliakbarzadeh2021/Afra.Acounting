using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsVchItmBaseRepository : Repository<TrsVchItmBase> , ITrsVchItmBaseRepository
    {
        public TrsVchItmBaseRepository(DataContext context) : base(context)
        {
        }
    }
}
