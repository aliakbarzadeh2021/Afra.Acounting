using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsDepositCalcRepository : Repository<TrsDepositCalc> , ITrsDepositCalcRepository
    {
        public TrsDepositCalcRepository(DataContext context) : base(context)
        {
        }
    }
}
