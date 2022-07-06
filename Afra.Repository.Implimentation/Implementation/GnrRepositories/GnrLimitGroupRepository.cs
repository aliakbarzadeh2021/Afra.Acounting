using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrLimitGroupRepository : Repository<GnrLimitGroup> , IGnrLimitGroupRepository
    {
        public GnrLimitGroupRepository(DataContext context) : base(context)
        {
        }
    }
}
