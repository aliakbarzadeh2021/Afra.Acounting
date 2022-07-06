using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class WorkFlowsFormRepository : Repository<WorkFlowsForm> , IWorkFlowsFormRepository
    {
        public WorkFlowsFormRepository(DataContext context) : base(context)
        {
        }
    }
}
