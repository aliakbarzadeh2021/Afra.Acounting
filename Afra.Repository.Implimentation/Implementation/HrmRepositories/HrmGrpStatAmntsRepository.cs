using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmGrpStatAmntsRepository : Repository<HrmGrpStatAmnts> , IHrmGrpStatAmntsRepository
    {
        public HrmGrpStatAmntsRepository(DataContext context) : base(context)
        {
        }
    }
}
