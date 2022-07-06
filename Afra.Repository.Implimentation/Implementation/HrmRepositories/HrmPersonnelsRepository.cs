using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmPersonnelsRepository : Repository<HrmPersonnels> , IHrmPersonnelsRepository
    {
        public HrmPersonnelsRepository(DataContext context) : base(context)
        {
        }
    }
}
