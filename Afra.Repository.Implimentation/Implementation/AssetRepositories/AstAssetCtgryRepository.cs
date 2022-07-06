using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstAssetCtgryRepository : Repository<AstAssetCtgry> , IAstAssetCtgryRepository
    {
        public AstAssetCtgryRepository(DataContext context) : base(context)
        {
        }
    }
}
