using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdOrdHdrRepository : Repository<PrdOrdHdr> , IPrdOrdHdrRepository
    {
        public PrdOrdHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
