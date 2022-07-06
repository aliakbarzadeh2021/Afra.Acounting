using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrFactHdrRepository : Repository<CmrFactHdr> , ICmrFactHdrRepository
    {
        public CmrFactHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
