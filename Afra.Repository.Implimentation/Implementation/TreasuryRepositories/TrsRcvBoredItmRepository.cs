using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsRcvBoredItmRepository : Repository<TrsRcvBoredItm> , ITrsRcvBoredItmRepository
    {
        public TrsRcvBoredItmRepository(DataContext context) : base(context)
        {
        }
    }
}
