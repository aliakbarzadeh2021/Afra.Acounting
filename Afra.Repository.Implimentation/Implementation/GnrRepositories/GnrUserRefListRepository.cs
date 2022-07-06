using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUserRefListRepository : Repository<GnrUserRefList> , IGnrUserRefListRepository
    {
        public GnrUserRefListRepository(DataContext context) : base(context)
        {
        }
    }
}
