using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrReportsRepository : Repository<GnrReports> , IGnrReportsRepository
    {
        public GnrReportsRepository(DataContext context) : base(context)
        {
        }
    }
}
