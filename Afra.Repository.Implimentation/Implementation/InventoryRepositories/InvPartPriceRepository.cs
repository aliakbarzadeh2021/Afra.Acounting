using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvPartPriceRepository : Repository<InvPartPrice> , IInvPartPriceRepository
    {
        public InvPartPriceRepository(DataContext context) : base(context)
        {
        }
    }
}
