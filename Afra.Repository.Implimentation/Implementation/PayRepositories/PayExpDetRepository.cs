using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayExpDetRepository : Repository<PayExpDet> , IPayExpDetRepository
    {
        public PayExpDetRepository(DataContext context) : base(context)
        {
        }
    }
}
