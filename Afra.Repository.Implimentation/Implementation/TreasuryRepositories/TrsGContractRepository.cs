using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsGContractRepository : Repository<TrsGContract> , ITrsGContractRepository
    {
        public TrsGContractRepository(DataContext context) : base(context)
        {
        }
    }
}
