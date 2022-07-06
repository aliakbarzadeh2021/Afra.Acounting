using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmTablesDetRepository : Repository<HrmTablesDet> , IHrmTablesDetRepository
    {
        public HrmTablesDetRepository(DataContext context) : base(context)
        {
        }
    }
}
