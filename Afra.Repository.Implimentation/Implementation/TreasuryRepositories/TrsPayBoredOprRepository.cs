using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsPayBoredOprRepository : Repository<TrsPayBoredOpr> , ITrsPayBoredOprRepository
    {
        public TrsPayBoredOprRepository(DataContext context) : base(context)
        {
        }
    }
}
