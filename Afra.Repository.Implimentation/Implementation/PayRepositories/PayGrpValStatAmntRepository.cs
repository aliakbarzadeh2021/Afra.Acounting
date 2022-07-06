using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayGrpValStatAmntRepository : Repository<PayGrpValStatAmnt> , IPayGrpValStatAmntRepository
    {
        public PayGrpValStatAmntRepository(DataContext context) : base(context)
        {
        }
    }
}
