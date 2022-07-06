using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgProfitDetRepository : Repository<BdgProfitDet> , IBdgProfitDetRepository
    {
        public BdgProfitDetRepository(DataContext context) : base(context)
        {
        }
    }
}
