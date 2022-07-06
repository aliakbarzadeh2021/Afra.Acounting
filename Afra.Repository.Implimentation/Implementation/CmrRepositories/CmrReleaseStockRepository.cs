using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrReleaseStockRepository : Repository<CmrReleaseStock> , ICmrReleaseStockRepository
    {
        public CmrReleaseStockRepository(DataContext context) : base(context)
        {
        }
    }
}
