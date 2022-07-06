using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class WorkFlowStepsRepository : Repository<WorkFlowSteps> , IWorkFlowStepsRepository
    {
        public WorkFlowStepsRepository(DataContext context) : base(context)
        {
        }
    }
}
