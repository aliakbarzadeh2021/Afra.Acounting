using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoLttrLinksRepository : Repository<OtoLttrLinks> , IOtoLttrLinksRepository
    {
        public OtoLttrLinksRepository(DataContext context) : base(context)
        {
        }
    }
}
