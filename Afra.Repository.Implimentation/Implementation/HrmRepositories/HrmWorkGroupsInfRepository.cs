using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmWorkGroupsInfRepository : Repository<HrmWorkGroupsInf> , IHrmWorkGroupsInfRepository
    {
        public HrmWorkGroupsInfRepository(DataContext context) : base(context)
        {
        }
    }
}
