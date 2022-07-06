using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdPOrdItmRepository : Repository<PrdPOrdItm> , IPrdPOrdItmRepository
    {
        public PrdPOrdItmRepository(DataContext context) : base(context)
        {
        }
    }
}
