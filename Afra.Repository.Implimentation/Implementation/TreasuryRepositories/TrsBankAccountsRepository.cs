using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsBankAccountsRepository : Repository<TrsBankAccounts> , ITrsBankAccountsRepository
    {
        public TrsBankAccountsRepository(DataContext context) : base(context)
        {
        }
    }
}
