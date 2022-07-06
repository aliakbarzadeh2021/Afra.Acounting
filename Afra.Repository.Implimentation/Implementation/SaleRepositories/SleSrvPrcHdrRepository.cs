using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleSrvPrcHdrRepository : Repository<SleSrvPrcHdr> , ISleSrvPrcHdrRepository
    {
        public SleSrvPrcHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
