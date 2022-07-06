using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsBankBranchsRepository : Repository<TrsBankBranchs> , ITrsBankBranchsRepository
    {
        public TrsBankBranchsRepository(DataContext context) : base(context)
        {
        }
    }
}
