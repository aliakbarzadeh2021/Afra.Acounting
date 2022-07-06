using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntAmntCurInfRepository : Repository<CntAmntCurInf> , ICntAmntCurInfRepository
    {
        public CntAmntCurInfRepository(DataContext context) : base(context)
        {
        }
    }
}
