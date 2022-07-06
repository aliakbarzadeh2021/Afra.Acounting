using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstAssetCostRepository : Repository<AstAssetCost> , IAstAssetCostRepository
    {
        public AstAssetCostRepository(DataContext context) : base(context)
        {
        }
    }
}
