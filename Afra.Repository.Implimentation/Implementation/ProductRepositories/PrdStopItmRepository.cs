using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdStopItmRepository : Repository<PrdStopItm> , IPrdStopItmRepository
    {
        public PrdStopItmRepository(DataContext context) : base(context)
        {
        }
    }
}
