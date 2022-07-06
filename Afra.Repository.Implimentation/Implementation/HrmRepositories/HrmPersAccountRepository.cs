using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmPersAccountRepository : Repository<HrmPersAccount> , IHrmPersAccountRepository
    {
        public HrmPersAccountRepository(DataContext context) : base(context)
        {
        }
    }
}
