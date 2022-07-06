using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrBuyServiceDetRepository : Repository<UsrBuyServiceDet> , IUsrBuyServiceDetRepository
    {
        public UsrBuyServiceDetRepository(DataContext context) : base(context)
        {
        }
    }
}
