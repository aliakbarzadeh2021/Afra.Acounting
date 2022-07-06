using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmIncDecWorkRepository : Repository<HrmIncDecWork> , IHrmIncDecWorkRepository
    {
        public HrmIncDecWorkRepository(DataContext context) : base(context)
        {
        }
    }
}
