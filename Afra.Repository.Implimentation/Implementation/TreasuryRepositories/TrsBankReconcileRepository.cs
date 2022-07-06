using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsBankReconcileRepository : Repository<TrsBankReconcile> , ITrsBankReconcileRepository
    {
        public TrsBankReconcileRepository(DataContext context) : base(context)
        {
        }
    }
}
