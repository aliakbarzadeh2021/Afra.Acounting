using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrPOrderHdrRepository : Repository<CmrPOrderHdr> , ICmrPOrderHdrRepository
    {
        public CmrPOrderHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
