using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrSysMsgDetRepository : Repository<GnrSysMsgDet> , IGnrSysMsgDetRepository
    {
        public GnrSysMsgDetRepository(DataContext context) : base(context)
        {
        }
    }
}
