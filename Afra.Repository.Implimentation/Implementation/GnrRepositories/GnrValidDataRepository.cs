using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrValidDataRepository : Repository<GnrValidData> , IGnrValidDataRepository
    {
        public GnrValidDataRepository(DataContext context) : base(context)
        {
        }
    }
}
