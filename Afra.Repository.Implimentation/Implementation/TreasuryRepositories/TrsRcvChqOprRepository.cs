using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsRcvChqOprRepository : Repository<TrsRcvChqOpr> , ITrsRcvChqOprRepository
    {
        public TrsRcvChqOprRepository(DataContext context) : base(context)
        {
        }
    }
}
