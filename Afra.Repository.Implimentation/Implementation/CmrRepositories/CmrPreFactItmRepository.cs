using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrPreFactItmRepository : Repository<CmrPreFactItm> , ICmrPreFactItmRepository
    {
        public CmrPreFactItmRepository(DataContext context) : base(context)
        {
        }
    }
}
