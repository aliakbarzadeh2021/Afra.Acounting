using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoLttrDocRepository : Repository<OtoLttrDoc> , IOtoLttrDocRepository
    {
        public OtoLttrDocRepository(DataContext context) : base(context)
        {
        }
    }
}
