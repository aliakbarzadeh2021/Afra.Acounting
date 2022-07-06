using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFixAccRepository : Repository<TrsFixAcc> , ITrsFixAccRepository
    {
        public TrsFixAccRepository(DataContext context) : base(context)
        {
        }
    }
}
