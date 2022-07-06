using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class HrmNumberingRepository : Repository<HrmNumbering> , IHrmNumberingRepository
    {
        public HrmNumberingRepository(DataContext context) : base(context)
        {
        }
    }
}
