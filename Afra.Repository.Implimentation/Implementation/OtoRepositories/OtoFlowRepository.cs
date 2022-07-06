using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoFlowRepository : Repository<OtoFlow> , IOtoFlowRepository
    {
        public OtoFlowRepository(DataContext context) : base(context)
        {
        }
    }
}
