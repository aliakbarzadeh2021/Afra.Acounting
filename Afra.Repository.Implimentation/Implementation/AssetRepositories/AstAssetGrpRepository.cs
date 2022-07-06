using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstAssetGrpRepository : Repository<AstAssetGrp> , IAstAssetGrpRepository
    {
        public AstAssetGrpRepository(DataContext context) : base(context)
        {
        }
    }
}
