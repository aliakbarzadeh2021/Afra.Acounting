using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstAssetRateRepository : Repository<AstAssetRate> , IAstAssetRateRepository
    {
        public AstAssetRateRepository(DataContext context) : base(context)
        {
        }
    }
}
