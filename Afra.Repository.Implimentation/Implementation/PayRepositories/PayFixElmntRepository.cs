using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayFixElmntRepository : Repository<PayFixElmnt> , IPayFixElmntRepository
    {
        public PayFixElmntRepository(DataContext context) : base(context)
        {
        }
    }
}
