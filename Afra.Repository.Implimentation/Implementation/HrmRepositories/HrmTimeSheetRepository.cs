using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmTimeSheetRepository : Repository<HrmTimeSheet> , IHrmTimeSheetRepository
    {
        public HrmTimeSheetRepository(DataContext context) : base(context)
        {
        }
    }
}
