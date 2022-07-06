using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgAssetsRepository : Repository<BdgAssets> , IBdgAssetsRepository
    {
        public BdgAssetsRepository(DataContext context) : base(context)
        {
        }
    }
}
