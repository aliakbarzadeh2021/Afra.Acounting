using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstAssetSaleRepository : Repository<AstAssetSale> , IAstAssetSaleRepository
    {
        public AstAssetSaleRepository(DataContext context) : base(context)
        {
        }
    }
}
