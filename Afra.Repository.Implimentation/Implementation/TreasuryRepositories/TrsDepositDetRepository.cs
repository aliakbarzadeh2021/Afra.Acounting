using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsDepositDetRepository : Repository<TrsDepositDet> , ITrsDepositDetRepository
    {
        public TrsDepositDetRepository(DataContext context) : base(context)
        {
        }
    }
}
