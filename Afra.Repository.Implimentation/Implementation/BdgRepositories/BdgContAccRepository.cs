using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgContAccRepository : Repository<BdgContAcc> , IBdgContAccRepository
    {
        public BdgContAccRepository(DataContext context) : base(context)
        {
        }
    }
}
