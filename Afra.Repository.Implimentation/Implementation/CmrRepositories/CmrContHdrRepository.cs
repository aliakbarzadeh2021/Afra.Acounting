using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrContHdrRepository : Repository<CmrContHdr> , ICmrContHdrRepository
    {
        public CmrContHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
