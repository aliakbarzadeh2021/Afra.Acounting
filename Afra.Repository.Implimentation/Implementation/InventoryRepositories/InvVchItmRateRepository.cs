using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvVchItmRateRepository : Repository<InvVchItmRate> , IInvVchItmRateRepository
    {
        public InvVchItmRateRepository(DataContext context) : base(context)
        {
        }
    }
}
