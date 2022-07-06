using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrProcessDetValsRepository : Repository<GnrProcessDetVals> , IGnrProcessDetValsRepository
    {
        public GnrProcessDetValsRepository(DataContext context) : base(context)
        {
        }
    }
}
