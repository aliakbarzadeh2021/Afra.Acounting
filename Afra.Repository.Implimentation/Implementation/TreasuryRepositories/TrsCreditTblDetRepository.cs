using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsCreditTblDetRepository : Repository<TrsCreditTblDet> , ITrsCreditTblDetRepository
    {
        public TrsCreditTblDetRepository(DataContext context) : base(context)
        {
        }
    }
}
