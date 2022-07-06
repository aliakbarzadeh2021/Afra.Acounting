using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgAssetsDetRepository : Repository<BdgAssetsDet> , IBdgAssetsDetRepository
    {
        public BdgAssetsDetRepository(DataContext context) : base(context)
        {
        }
    }
}
