using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrProcessRepository : Repository<GnrProcess> , IGnrProcessRepository
    {
        public GnrProcessRepository(DataContext context) : base(context)
        {
        }
    }
}
