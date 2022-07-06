using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrRptGroupsRepository : Repository<GnrRptGroups> , IGnrRptGroupsRepository
    {
        public GnrRptGroupsRepository(DataContext context) : base(context)
        {
        }
    }
}
