using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsGContractChngRepository : Repository<TrsGContractChng> , ITrsGContractChngRepository
    {
        public TrsGContractChngRepository(DataContext context) : base(context)
        {
        }
    }
}
