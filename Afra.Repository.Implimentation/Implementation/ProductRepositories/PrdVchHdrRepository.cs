using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdVchHdrRepository : Repository<PrdVchHdr> , IPrdVchHdrRepository
    {
        public PrdVchHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
