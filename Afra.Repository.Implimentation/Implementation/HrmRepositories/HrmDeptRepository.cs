using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmDeptRepository : Repository<HrmDept> , IHrmDeptRepository
    {
        public HrmDeptRepository(DataContext context) : base(context)
        {
        }
    }
}
