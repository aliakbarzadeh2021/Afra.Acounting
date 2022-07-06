using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgElementsRepository : Repository<BdgElements> , IBdgElementsRepository
    {
        public BdgElementsRepository(DataContext context) : base(context)
        {
        }
    }
}
