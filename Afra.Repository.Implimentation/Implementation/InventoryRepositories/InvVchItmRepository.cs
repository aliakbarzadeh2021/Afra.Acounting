using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvVchItmRepository : Repository<InvVchItm> , IInvVchItmRepository
    {
        public InvVchItmRepository(DataContext context) : base(context)
        {
        }
    }
}
