using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUserLogRepository : Repository<GnrUserLog> , IGnrUserLogRepository
    {
        public GnrUserLogRepository(DataContext context) : base(context)
        {
        }
    }
}
