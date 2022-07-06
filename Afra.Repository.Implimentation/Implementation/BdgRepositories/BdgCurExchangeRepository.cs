using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgCurExchangeRepository : Repository<BdgCurExchange> , IBdgCurExchangeRepository
    {
        public BdgCurExchangeRepository(DataContext context) : base(context)
        {
        }
    }
}
