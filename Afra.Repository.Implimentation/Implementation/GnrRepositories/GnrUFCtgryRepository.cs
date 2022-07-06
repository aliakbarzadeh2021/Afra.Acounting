using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUFCtgryRepository : Repository<GnrUFCtgry> , IGnrUFCtgryRepository
    {
        public GnrUFCtgryRepository(DataContext context) : base(context)
        {
        }
    }
}
