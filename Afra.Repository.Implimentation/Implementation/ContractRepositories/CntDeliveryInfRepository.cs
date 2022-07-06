using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntDeliveryInfRepository : Repository<CntDeliveryInf> , ICntDeliveryInfRepository
    {
        public CntDeliveryInfRepository(DataContext context) : base(context)
        {
        }
    }
}
