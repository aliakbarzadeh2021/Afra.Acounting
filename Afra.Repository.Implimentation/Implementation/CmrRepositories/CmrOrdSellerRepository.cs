using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrOrdSellerRepository : Repository<CmrOrdSeller> , ICmrOrdSellerRepository
    {
        public CmrOrdSellerRepository(DataContext context) : base(context)
        {
        }
    }
}
