using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleLimitsRepository : Repository<SleLimits> , ISleLimitsRepository
    {
        public SleLimitsRepository(DataContext context) : base(context)
        {
        }
    }
}
