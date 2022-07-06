using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayCompsRepository : Repository<PayComps> , IPayCompsRepository
    {
        public PayCompsRepository(DataContext context) : base(context)
        {
        }
    }
}
