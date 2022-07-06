using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvPartStockRelRepository : Repository<InvPartStockRel> , IInvPartStockRelRepository
    {
        public InvPartStockRelRepository(DataContext context) : base(context)
        {
        }
    }
}
