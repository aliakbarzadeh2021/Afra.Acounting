using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoIndicatorRepository : Repository<OtoIndicator> , IOtoIndicatorRepository
    {
        public OtoIndicatorRepository(DataContext context) : base(context)
        {
        }
    }
}
