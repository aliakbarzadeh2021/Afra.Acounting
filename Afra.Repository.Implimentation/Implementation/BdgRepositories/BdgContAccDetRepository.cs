using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgContAccDetRepository : Repository<BdgContAccDet> , IBdgContAccDetRepository
    {
        public BdgContAccDetRepository(DataContext context) : base(context)
        {
        }
    }
}
