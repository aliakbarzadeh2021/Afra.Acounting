using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrCashRepository : Repository<UsrCash> , IUsrCashRepository
    {
        public UsrCashRepository(DataContext context) : base(context)
        {
        }
    }
}
