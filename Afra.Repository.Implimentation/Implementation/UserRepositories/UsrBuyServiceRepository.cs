using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrBuyServiceRepository : Repository<UsrBuyService> , IUsrBuyServiceRepository
    {
        public UsrBuyServiceRepository(DataContext context) : base(context)
        {
        }
    }
}
