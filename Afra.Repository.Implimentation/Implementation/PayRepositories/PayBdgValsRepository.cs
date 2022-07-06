using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayBdgValsRepository : Repository<PayBdgVals> , IPayBdgValsRepository
    {
        public PayBdgValsRepository(DataContext context) : base(context)
        {
        }
    }
}
