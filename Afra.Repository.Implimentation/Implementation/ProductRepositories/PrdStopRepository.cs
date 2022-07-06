using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdStopRepository : Repository<PrdStop> , IPrdStopRepository
    {
        public PrdStopRepository(DataContext context) : base(context)
        {
        }
    }
}
