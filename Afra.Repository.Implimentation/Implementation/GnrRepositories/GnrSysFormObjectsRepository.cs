using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrSysFormObjectsRepository : Repository<GnrSysFormObjects> , IGnrSysFormObjectsRepository
    {
        public GnrSysFormObjectsRepository(DataContext context) : base(context)
        {
        }
    }
}
