using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrPreFactHdrRepository : Repository<CmrPreFactHdr> , ICmrPreFactHdrRepository
    {
        public CmrPreFactHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
