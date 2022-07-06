using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsRcvHistoryRepository : Repository<TrsRcvHistory> , ITrsRcvHistoryRepository
    {
        public TrsRcvHistoryRepository(DataContext context) : base(context)
        {
        }
    }
}
