using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmAimElmntsRepository : Repository<HrmAimElmnts> , IHrmAimElmntsRepository
    {
        public HrmAimElmntsRepository(DataContext context) : base(context)
        {
        }
    }
}
