using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayVchDetRepository : Repository<PayVchDet> , IPayVchDetRepository
    {
        public PayVchDetRepository(DataContext context) : base(context)
        {
        }
    }
}
