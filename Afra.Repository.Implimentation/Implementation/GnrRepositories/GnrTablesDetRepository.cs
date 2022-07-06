using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrTablesDetRepository : Repository<GnrTablesDet> , IGnrTablesDetRepository
    {
        public GnrTablesDetRepository(DataContext context) : base(context)
        {
        }
    }
}
