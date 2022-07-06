using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntContAmntChngRepository : Repository<CntContAmntChng> , ICntContAmntChngRepository
    {
        public CntContAmntChngRepository(DataContext context) : base(context)
        {
        }
    }
}
