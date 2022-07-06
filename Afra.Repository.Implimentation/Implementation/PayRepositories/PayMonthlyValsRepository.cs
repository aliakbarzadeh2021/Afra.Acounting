using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayMonthlyValsRepository : Repository<PayMonthlyVals> , IPayMonthlyValsRepository
    {
        public PayMonthlyValsRepository(DataContext context) : base(context)
        {
        }
    }
}
