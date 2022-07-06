using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleChngVchHdrRepository : Repository<SleChngVchHdr> , ISleChngVchHdrRepository
    {
        public SleChngVchHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
