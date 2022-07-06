using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayVacMonthlyRepository : Repository<PayVacMonthly> , IPayVacMonthlyRepository
    {
        public PayVacMonthlyRepository(DataContext context) : base(context)
        {
        }
    }
}
