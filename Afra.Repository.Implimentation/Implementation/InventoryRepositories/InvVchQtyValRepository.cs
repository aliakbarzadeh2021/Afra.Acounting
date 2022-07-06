using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvVchQtyValRepository : Repository<InvVchQtyVal> , IInvVchQtyValRepository
    {
        public InvVchQtyValRepository(DataContext context) : base(context)
        {
        }
    }
}
