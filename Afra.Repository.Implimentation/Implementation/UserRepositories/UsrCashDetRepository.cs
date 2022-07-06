using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrCashDetRepository : Repository<UsrCashDet> , IUsrCashDetRepository
    {
        public UsrCashDetRepository(DataContext context) : base(context)
        {
        }
    }
}
