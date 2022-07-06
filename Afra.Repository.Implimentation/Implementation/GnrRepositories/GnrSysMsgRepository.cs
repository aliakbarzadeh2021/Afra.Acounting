using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrSysMsgRepository : Repository<GnrSysMsg> , IGnrSysMsgRepository
    {
        public GnrSysMsgRepository(DataContext context) : base(context)
        {
        }
    }
}
