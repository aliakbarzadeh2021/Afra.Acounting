using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayTaxTableRepository : Repository<PayTaxTable> , IPayTaxTableRepository
    {
        public PayTaxTableRepository(DataContext context) : base(context)
        {
        }
    }
}
