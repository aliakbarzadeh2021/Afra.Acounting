using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsrProdCostRepository : Repository<UsrProdCost> , IUsrProdCostRepository
    {
        public UsrProdCostRepository(DataContext context) : base(context)
        {
        }
    }
}
