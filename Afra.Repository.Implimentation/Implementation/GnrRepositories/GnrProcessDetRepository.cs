using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrProcessDetRepository : Repository<GnrProcessDet> , IGnrProcessDetRepository
    {
        public GnrProcessDetRepository(DataContext context) : base(context)
        {
        }
    }
}
