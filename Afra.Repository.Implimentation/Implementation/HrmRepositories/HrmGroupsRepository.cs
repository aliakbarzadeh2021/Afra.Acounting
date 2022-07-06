using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmGroupsRepository : Repository<HrmGroups> , IHrmGroupsRepository
    {
        public HrmGroupsRepository(DataContext context) : base(context)
        {
        }
    }
}
