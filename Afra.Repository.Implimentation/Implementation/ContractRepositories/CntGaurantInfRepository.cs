using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntGaurantInfRepository : Repository<CntGaurantInf> , ICntGaurantInfRepository
    {
        public CntGaurantInfRepository(DataContext context) : base(context)
        {
        }
    }
}
