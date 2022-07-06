using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdOrdItmRepository : Repository<PrdOrdItm> , IPrdOrdItmRepository
    {
        public PrdOrdItmRepository(DataContext context) : base(context)
        {
        }
    }
}
