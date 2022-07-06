using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class WorkFlowsRepository : Repository<WorkFlows> , IWorkFlowsRepository
    {
        public WorkFlowsRepository(DataContext context) : base(context)
        {
        }
    }
}
