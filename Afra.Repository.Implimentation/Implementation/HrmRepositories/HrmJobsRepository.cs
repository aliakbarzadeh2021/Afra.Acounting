using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmJobsRepository : Repository<HrmJobs> , IHrmJobsRepository
    {
        public HrmJobsRepository(DataContext context) : base(context)
        {
        }
    }
}
