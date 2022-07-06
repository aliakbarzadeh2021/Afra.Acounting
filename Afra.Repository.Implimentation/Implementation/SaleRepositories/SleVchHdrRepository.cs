using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleVchHdrRepository : Repository<SleVchHdr> , ISleVchHdrRepository
    {
        public SleVchHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
