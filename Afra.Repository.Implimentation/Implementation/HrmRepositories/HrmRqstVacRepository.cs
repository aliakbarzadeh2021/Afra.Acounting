using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmRqstVacRepository : Repository<HrmRqstVac> , IHrmRqstVacRepository
    {
        public HrmRqstVacRepository(DataContext context) : base(context)
        {
        }
    }
}
