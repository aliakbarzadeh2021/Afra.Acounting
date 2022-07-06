using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvStckPeriodRepository : Repository<InvStckPeriod> , IInvStckPeriodRepository
    {
        public InvStckPeriodRepository(DataContext context) : base(context)
        {
        }
    }
}
