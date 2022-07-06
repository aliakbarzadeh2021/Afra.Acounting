using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrRqstHdrRepository : Repository<CmrRqstHdr> , ICmrRqstHdrRepository
    {
        public CmrRqstHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
