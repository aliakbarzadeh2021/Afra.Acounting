using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdPersWorkStRepository : Repository<PrdPersWorkSt> , IPrdPersWorkStRepository
    {
        public PrdPersWorkStRepository(DataContext context) : base(context)
        {
        }
    }
}
