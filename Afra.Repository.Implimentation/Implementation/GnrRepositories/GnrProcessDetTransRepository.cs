using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrProcessDetTransRepository : Repository<GnrProcessDetTrans> , IGnrProcessDetTransRepository
    {
        public GnrProcessDetTransRepository(DataContext context) : base(context)
        {
        }
    }
}
