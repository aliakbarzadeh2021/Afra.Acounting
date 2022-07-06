using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntSrvPrcItmRepository : Repository<CntSrvPrcItm> , ICntSrvPrcItmRepository
    {
        public CntSrvPrcItmRepository(DataContext context) : base(context)
        {
        }
    }
}
