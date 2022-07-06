using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrContItmRepository : Repository<CmrContItm> , ICmrContItmRepository
    {
        public CmrContItmRepository(DataContext context) : base(context)
        {
        }
    }
}
