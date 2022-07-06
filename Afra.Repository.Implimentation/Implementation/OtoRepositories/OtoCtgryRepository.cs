using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoCtgryRepository : Repository<OtoCtgry> , IOtoCtgryRepository
    {
        public OtoCtgryRepository(DataContext context) : base(context)
        {
        }
    }
}
