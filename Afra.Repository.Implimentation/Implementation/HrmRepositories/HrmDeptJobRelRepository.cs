using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmDeptJobRelRepository : Repository<HrmDeptJobRel> , IHrmDeptJobRelRepository
    {
        public HrmDeptJobRelRepository(DataContext context) : base(context)
        {
        }
    }
}
