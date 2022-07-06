using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgHrmValsPersRepository : Repository<BdgHrmValsPers> , IBdgHrmValsPersRepository
    {
        public BdgHrmValsPersRepository(DataContext context) : base(context)
        {
        }
    }
}
