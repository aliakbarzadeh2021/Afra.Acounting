using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstAssetInfRepository : Repository<AstAssetInf> , IAstAssetInfRepository
    {
        public AstAssetInfRepository(DataContext context) : base(context)
        {
        }
    }
}
