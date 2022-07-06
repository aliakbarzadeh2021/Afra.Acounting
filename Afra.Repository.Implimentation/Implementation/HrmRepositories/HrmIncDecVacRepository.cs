using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmIncDecVacRepository : Repository<HrmIncDecVac> , IHrmIncDecVacRepository
    {
        public HrmIncDecVacRepository(DataContext context) : base(context)
        {
        }
    }
}
