using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmPersParamRepository : Repository<HrmPersParam> , IHrmPersParamRepository
    {
        public HrmPersParamRepository(DataContext context) : base(context)
        {
        }
    }
}
