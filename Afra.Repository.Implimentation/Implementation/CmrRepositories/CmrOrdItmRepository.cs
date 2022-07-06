using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrOrdItmRepository : Repository<CmrOrdItm> , ICmrOrdItmRepository
    {
        public CmrOrdItmRepository(DataContext context) : base(context)
        {
        }
    }
}
