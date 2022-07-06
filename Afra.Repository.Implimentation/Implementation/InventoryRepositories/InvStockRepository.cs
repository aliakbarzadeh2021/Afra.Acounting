using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvStockRepository : Repository<InvStock> , IInvStockRepository
    {
        public InvStockRepository(DataContext context) : base(context)
        {
        }
    }
}
