using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayMonthlyMthdRepository : Repository<PayMonthlyMthd> , IPayMonthlyMthdRepository
    {
        public PayMonthlyMthdRepository(DataContext context) : base(context)
        {
        }
    }
}
