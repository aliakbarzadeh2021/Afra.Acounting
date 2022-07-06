using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdSchStopRepository : Repository<PrdSchStop> , IPrdSchStopRepository
    {
        public PrdSchStopRepository(DataContext context) : base(context)
        {
        }
    }
}
