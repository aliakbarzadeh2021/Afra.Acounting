using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvPartCtgryAccRepository : Repository<InvPartCtgryAcc> , IInvPartCtgryAccRepository
    {
        public InvPartCtgryAccRepository(DataContext context) : base(context)
        {
        }
    }
}
