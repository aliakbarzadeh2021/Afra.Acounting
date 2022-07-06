using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsBankBillRepository : Repository<TrsBankBill> , ITrsBankBillRepository
    {
        public TrsBankBillRepository(DataContext context) : base(context)
        {
        }
    }
}
