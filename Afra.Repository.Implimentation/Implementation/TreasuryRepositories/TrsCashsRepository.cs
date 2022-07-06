using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsCashsRepository : Repository<TrsCashs> , ITrsCashsRepository
    {
        public TrsCashsRepository(DataContext context) : base(context)
        {
        }
    }
}
