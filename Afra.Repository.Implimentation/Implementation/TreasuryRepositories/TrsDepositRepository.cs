using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsDepositRepository : Repository<TrsDeposit> , ITrsDepositRepository
    {
        public TrsDepositRepository(DataContext context) : base(context)
        {
        }
    }
}
