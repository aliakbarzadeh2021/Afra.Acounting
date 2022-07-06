using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsBanksRepository : Repository<TrsBanks> , ITrsBanksRepository
    {
        public TrsBanksRepository(DataContext context) : base(context)
        {
        }
    }
}
