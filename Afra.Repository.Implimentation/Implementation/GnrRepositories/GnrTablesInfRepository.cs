using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrTablesInfRepository : Repository<GnrTablesInf> , IGnrTablesInfRepository
    {
        public GnrTablesInfRepository(DataContext context) : base(context)
        {
        }
    }
}
