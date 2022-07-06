using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvStockUserRepository : Repository<InvStockUser> , IInvStockUserRepository
    {
        public InvStockUserRepository(DataContext context) : base(context)
        {
        }
    }
}
