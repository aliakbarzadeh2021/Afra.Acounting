using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdVchItmRepository : Repository<PrdVchItm> , IPrdVchItmRepository
    {
        public PrdVchItmRepository(DataContext context) : base(context)
        {
        }
    }
}
