using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayGrpValStatRepository : Repository<PayGrpValStat> , IPayGrpValStatRepository
    {
        public PayGrpValStatRepository(DataContext context) : base(context)
        {
        }
    }
}
