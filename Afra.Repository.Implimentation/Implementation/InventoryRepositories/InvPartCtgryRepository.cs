using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvPartCtgryRepository : Repository<InvPartCtgry> , IInvPartCtgryRepository
    {
        public InvPartCtgryRepository(DataContext context) : base(context)
        {
        }
    }
}
