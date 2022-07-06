using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrToolsRepository : Repository<GnrTools> , IGnrToolsRepository
    {
        public GnrToolsRepository(DataContext context) : base(context)
        {
        }
    }
}
