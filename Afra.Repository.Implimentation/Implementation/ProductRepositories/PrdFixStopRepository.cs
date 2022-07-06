using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdFixStopRepository : Repository<PrdFixStop> , IPrdFixStopRepository
    {
        public PrdFixStopRepository(DataContext context) : base(context)
        {
        }
    }
}
