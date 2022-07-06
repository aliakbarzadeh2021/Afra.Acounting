using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayPersEndRepository : Repository<PayPersEnd> , IPayPersEndRepository
    {
        public PayPersEndRepository(DataContext context) : base(context)
        {
        }
    }
}
