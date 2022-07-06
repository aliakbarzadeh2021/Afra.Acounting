using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TablesLastIdRepository : Repository<TablesLastId> , ITablesLastIdRepository
    {
        public TablesLastIdRepository(DataContext context) : base(context)
        {
        }
    }
}
