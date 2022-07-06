using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntContrLimitRepository : Repository<CntContrLimit> , ICntContrLimitRepository
    {
        public CntContrLimitRepository(DataContext context) : base(context)
        {
        }
    }
}
