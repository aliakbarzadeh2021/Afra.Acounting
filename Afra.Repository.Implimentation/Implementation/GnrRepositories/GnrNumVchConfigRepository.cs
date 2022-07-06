using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrNumVchConfigRepository : Repository<GnrNumVchConfig> , IGnrNumVchConfigRepository
    {
        public GnrNumVchConfigRepository(DataContext context) : base(context)
        {
        }
    }
}
