using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstAssetDeprRepository : Repository<AstAssetDepr> , IAstAssetDeprRepository
    {
        public AstAssetDeprRepository(DataContext context) : base(context)
        {
        }
    }
}
