using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoAttachRepository : Repository<OtoAttach> , IOtoAttachRepository
    {
        public OtoAttachRepository(DataContext context) : base(context)
        {
        }
    }
}
