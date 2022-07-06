using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdMatPlanRepository : Repository<PrdMatPlan> , IPrdMatPlanRepository
    {
        public PrdMatPlanRepository(DataContext context) : base(context)
        {
        }
    }
}
