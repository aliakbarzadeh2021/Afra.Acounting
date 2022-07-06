using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmTablesRepository : Repository<HrmTables> , IHrmTablesRepository
    {
        public HrmTablesRepository(DataContext context) : base(context)
        {
        }
    }
}
