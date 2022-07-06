using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayImpDetRepository : Repository<PayImpDet> , IPayImpDetRepository
    {
        public PayImpDetRepository(DataContext context) : base(context)
        {
        }
    }
}
