using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrSysQuerysRepository : Repository<GnrSysQuerys> , IGnrSysQuerysRepository
    {
        public GnrSysQuerysRepository(DataContext context) : base(context)
        {
        }
    }
}
