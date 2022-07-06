using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdConsumItmRepository : Repository<PrdConsumItm> , IPrdConsumItmRepository
    {
        public PrdConsumItmRepository(DataContext context) : base(context)
        {
        }
    }
}
