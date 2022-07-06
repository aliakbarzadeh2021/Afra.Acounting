using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrSysLogsRepository : Repository<GnrSysLogs> , IGnrSysLogsRepository
    {
        public GnrSysLogsRepository(DataContext context) : base(context)
        {
        }
    }
}
