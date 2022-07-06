using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUserMsgRepository : Repository<GnrUserMsg> , IGnrUserMsgRepository
    {
        public GnrUserMsgRepository(DataContext context) : base(context)
        {
        }
    }
}
