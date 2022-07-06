using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayBdgBaseRepository : Repository<PayBdgBase> , IPayBdgBaseRepository
    {
        public PayBdgBaseRepository(DataContext context) : base(context)
        {
        }
    }
}
