using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsVchItmRepository : Repository<TrsVchItm> , ITrsVchItmRepository
    {
        public TrsVchItmRepository(DataContext context) : base(context)
        {
        }
    }
}
