using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdOrdSchedRepository : Repository<PrdOrdSched> , IPrdOrdSchedRepository
    {
        public PrdOrdSchedRepository(DataContext context) : base(context)
        {
        }
    }
}
