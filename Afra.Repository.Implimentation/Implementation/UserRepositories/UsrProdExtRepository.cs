using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrProdExtRepository : Repository<UsrProdExt> , IUsrProdExtRepository
    {
        public UsrProdExtRepository(DataContext context) : base(context)
        {
        }
    }
}
