using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntSrvPrcHdrRepository : Repository<CntSrvPrcHdr> , ICntSrvPrcHdrRepository
    {
        public CntSrvPrcHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
