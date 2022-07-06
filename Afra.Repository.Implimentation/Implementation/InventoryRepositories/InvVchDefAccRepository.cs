using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvVchDefAccRepository : Repository<InvVchDefAcc> , IInvVchDefAccRepository
    {
        public InvVchDefAccRepository(DataContext context) : base(context)
        {
        }
    }
}
