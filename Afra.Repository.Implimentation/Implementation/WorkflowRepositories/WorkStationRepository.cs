using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class WorkStationRepository : Repository<WorkStation> , IWorkStationRepository
    {
        public WorkStationRepository(DataContext context) : base(context)
        {
        }
    }
}
