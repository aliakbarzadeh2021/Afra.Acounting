using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmGrpStatPersRepository : Repository<HrmGrpStatPers> , IHrmGrpStatPersRepository
    {
        public HrmGrpStatPersRepository(DataContext context) : base(context)
        {
        }
    }
}
