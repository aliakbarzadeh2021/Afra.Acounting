using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsPayChqOprRepository : Repository<TrsPayChqOpr> , ITrsPayChqOprRepository
    {
        public TrsPayChqOprRepository(DataContext context) : base(context)
        {
        }
    }
}
