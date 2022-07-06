using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmGrpCompAsignRepository : Repository<HrmGrpCompAsign> , IHrmGrpCompAsignRepository
    {
        public HrmGrpCompAsignRepository(DataContext context) : base(context)
        {
        }
    }
}
