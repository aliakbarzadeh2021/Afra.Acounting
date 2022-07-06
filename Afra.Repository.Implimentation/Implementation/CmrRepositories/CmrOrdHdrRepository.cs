using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrOrdHdrRepository : Repository<CmrOrdHdr> , ICmrOrdHdrRepository
    {
        public CmrOrdHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
