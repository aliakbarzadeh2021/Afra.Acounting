using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayGrpValStatPersRepository : Repository<PayGrpValStatPers> , IPayGrpValStatPersRepository
    {
        public PayGrpValStatPersRepository(DataContext context) : base(context)
        {
        }
    }
}
