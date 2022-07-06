using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmWorkGroupsRepository : Repository<HrmWorkGroups> , IHrmWorkGroupsRepository
    {
        public HrmWorkGroupsRepository(DataContext context) : base(context)
        {
        }
    }
}
