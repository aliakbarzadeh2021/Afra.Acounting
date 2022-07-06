using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrSysTablesRepository : Repository<GnrSysTables> , IGnrSysTablesRepository
    {
        public GnrSysTablesRepository(DataContext context) : base(context)
        {
        }
    }
}
