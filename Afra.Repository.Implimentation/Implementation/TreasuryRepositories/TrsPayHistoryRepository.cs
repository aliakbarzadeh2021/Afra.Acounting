using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsPayHistoryRepository : Repository<TrsPayHistory> , ITrsPayHistoryRepository
    {
        public TrsPayHistoryRepository(DataContext context) : base(context)
        {
        }
    }
}
