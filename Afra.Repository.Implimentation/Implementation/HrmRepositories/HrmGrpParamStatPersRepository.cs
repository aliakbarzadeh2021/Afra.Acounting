using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmGrpParamStatPersRepository : Repository<HrmGrpParamStatPers> , IHrmGrpParamStatPersRepository
    {
        public HrmGrpParamStatPersRepository(DataContext context) : base(context)
        {
        }
    }
}
