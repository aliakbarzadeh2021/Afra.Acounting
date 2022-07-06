using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvStckPeriodRelsRepository : Repository<InvStckPeriodRels> , IInvStckPeriodRelsRepository
    {
        public InvStckPeriodRelsRepository(DataContext context) : base(context)
        {
        }
    }
}
