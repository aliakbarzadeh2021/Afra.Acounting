using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmPersCompAsignRepository : Repository<HrmPersCompAsign> , IHrmPersCompAsignRepository
    {
        public HrmPersCompAsignRepository(DataContext context) : base(context)
        {
        }
    }
}
