using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsRcvBoredOprRepository : Repository<TrsRcvBoredOpr> , ITrsRcvBoredOprRepository
    {
        public TrsRcvBoredOprRepository(DataContext context) : base(context)
        {
        }
    }
}
