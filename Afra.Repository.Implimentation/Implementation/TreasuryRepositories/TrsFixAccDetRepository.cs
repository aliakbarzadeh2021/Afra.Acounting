using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFixAccDetRepository : Repository<TrsFixAccDet> , ITrsFixAccDetRepository
    {
        public TrsFixAccDetRepository(DataContext context) : base(context)
        {
        }
    }
}
