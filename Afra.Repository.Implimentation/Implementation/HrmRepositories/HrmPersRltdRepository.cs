using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmPersRltdRepository : Repository<HrmPersRltd> , IHrmPersRltdRepository
    {
        public HrmPersRltdRepository(DataContext context) : base(context)
        {
        }
    }
}
