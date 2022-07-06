using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFContractRepository : Repository<TrsFContract> , ITrsFContractRepository
    {
        public TrsFContractRepository(DataContext context) : base(context)
        {
        }
    }
}
