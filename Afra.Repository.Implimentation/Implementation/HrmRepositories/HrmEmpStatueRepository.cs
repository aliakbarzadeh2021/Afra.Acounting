using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmEmpStatueRepository : Repository<HrmEmpStatue> , IHrmEmpStatueRepository
    {
        public HrmEmpStatueRepository(DataContext context) : base(context)
        {
        }
    }
}
