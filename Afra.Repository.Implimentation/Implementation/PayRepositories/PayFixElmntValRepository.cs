using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PayFixElmntValRepository : Repository<PayFixElmntVal> , IPayFixElmntValRepository
    {
        public PayFixElmntValRepository(DataContext context) : base(context)
        {
        }
    }
}
