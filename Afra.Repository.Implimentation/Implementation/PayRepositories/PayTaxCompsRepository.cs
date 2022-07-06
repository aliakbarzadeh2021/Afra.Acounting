using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayTaxCompsRepository : Repository<PayTaxComps> , IPayTaxCompsRepository
    {
        public PayTaxCompsRepository(DataContext context) : base(context)
        {
        }
    }
}
