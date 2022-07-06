using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrSellerGrpRepository : Repository<CmrSellerGrp> , ICmrSellerGrpRepository
    {
        public CmrSellerGrpRepository(DataContext context) : base(context)
        {
        }
    }
}
