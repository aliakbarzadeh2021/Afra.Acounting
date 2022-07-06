using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrReleaseHdrRepository : Repository<CmrReleaseHdr> , ICmrReleaseHdrRepository
    {
        public CmrReleaseHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
