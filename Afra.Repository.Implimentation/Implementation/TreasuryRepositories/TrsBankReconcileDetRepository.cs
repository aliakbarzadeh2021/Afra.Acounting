using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsBankReconcileDetRepository : Repository<TrsBankReconcileDet> , ITrsBankReconcileDetRepository
    {
        public TrsBankReconcileDetRepository(DataContext context) : base(context)
        {
        }
    }
}
