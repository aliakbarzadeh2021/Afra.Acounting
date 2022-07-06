using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayTaxDetRepository : Repository<PayTaxDet> , IPayTaxDetRepository
    {
        public PayTaxDetRepository(DataContext context) : base(context)
        {
        }
    }
}
