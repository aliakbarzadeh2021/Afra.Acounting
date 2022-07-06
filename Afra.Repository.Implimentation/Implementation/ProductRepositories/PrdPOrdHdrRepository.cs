using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdPOrdHdrRepository : Repository<PrdPOrdHdr> , IPrdPOrdHdrRepository
    {
        public PrdPOrdHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
