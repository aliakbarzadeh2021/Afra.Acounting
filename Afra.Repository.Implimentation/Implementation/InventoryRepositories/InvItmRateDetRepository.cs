using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvItmRateDetRepository : Repository<InvItmRateDet> , IInvItmRateDetRepository
    {
        public InvItmRateDetRepository(DataContext context) : base(context)
        {
        }
    }
}
