using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvVchHdrRepository : Repository<InvVchHdr> , IInvVchHdrRepository
    {
        public InvVchHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
