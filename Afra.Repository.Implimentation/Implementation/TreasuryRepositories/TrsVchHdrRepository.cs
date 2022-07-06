using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsVchHdrRepository : Repository<TrsVchHdr> , ITrsVchHdrRepository
    {
        public TrsVchHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
