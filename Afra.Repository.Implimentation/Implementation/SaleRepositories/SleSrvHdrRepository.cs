using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleSrvHdrRepository : Repository<SleSrvHdr> , ISleSrvHdrRepository
    {
        public SleSrvHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
