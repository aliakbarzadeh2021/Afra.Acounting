using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayVacRemainRepository : Repository<PayVacRemain> , IPayVacRemainRepository
    {
        public PayVacRemainRepository(DataContext context) : base(context)
        {
        }
    }
}
