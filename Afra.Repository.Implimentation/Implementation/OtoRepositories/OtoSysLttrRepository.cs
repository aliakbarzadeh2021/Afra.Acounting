using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoSysLttrRepository : Repository<OtoSysLttr> , IOtoSysLttrRepository
    {
        public OtoSysLttrRepository(DataContext context) : base(context)
        {
        }
    }
}
