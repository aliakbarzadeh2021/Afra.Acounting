using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsCreditTblRepository : Repository<TrsCreditTbl> , ITrsCreditTblRepository
    {
        public TrsCreditTblRepository(DataContext context) : base(context)
        {
        }
    }
}
