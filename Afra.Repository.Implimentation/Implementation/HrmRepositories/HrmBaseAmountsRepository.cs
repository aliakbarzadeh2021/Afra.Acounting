using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmBaseAmountsRepository : Repository<HrmBaseAmounts> , IHrmBaseAmountsRepository
    {
        public HrmBaseAmountsRepository(DataContext context) : base(context)
        {
        }
    }
}
