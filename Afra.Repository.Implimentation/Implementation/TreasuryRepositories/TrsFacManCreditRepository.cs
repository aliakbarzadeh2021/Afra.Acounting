using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFacManCreditRepository : Repository<TrsFacManCredit> , ITrsFacManCreditRepository
    {
        public TrsFacManCreditRepository(DataContext context) : base(context)
        {
        }
    }
}
