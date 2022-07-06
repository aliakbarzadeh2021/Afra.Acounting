using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdConsumHdrRepository : Repository<PrdConsumHdr> , IPrdConsumHdrRepository
    {
        public PrdConsumHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
