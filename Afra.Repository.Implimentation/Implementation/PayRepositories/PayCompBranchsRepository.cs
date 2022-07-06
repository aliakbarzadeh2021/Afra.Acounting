using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayCompBranchsRepository : Repository<PayCompBranchs> , IPayCompBranchsRepository
    {
        public PayCompBranchsRepository(DataContext context) : base(context)
        {
        }
    }
}
