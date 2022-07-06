using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsPayBoredItmRepository : Repository<TrsPayBoredItm> , ITrsPayBoredItmRepository
    {
        public TrsPayBoredItmRepository(DataContext context) : base(context)
        {
        }
    }
}
