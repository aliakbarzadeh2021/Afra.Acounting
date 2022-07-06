using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrProdRcvRepository : Repository<UsrProdRcv> , IUsrProdRcvRepository
    {
        public UsrProdRcvRepository(DataContext context) : base(context)
        {
        }
    }
}
