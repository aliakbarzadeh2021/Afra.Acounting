using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoFlowRightRepository : Repository<OtoFlowRight> , IOtoFlowRightRepository
    {
        public OtoFlowRightRepository(DataContext context) : base(context)
        {
        }
    }
}
