using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrProcessDetArchRepository : Repository<GnrProcessDetArch> , IGnrProcessDetArchRepository
    {
        public GnrProcessDetArchRepository(DataContext context) : base(context)
        {
        }
    }
}
