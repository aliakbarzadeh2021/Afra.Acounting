using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrPersHrmRelsKigrRepository : Repository<UsrPersHrmRelsKigr> , IUsrPersHrmRelsKigrRepository
    {
        public UsrPersHrmRelsKigrRepository(DataContext context) : base(context)
        {
        }
    }
}
