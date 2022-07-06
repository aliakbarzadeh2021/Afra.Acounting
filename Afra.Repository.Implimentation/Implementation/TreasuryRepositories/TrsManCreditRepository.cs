using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsManCreditRepository : Repository<TrsManCredit> , ITrsManCreditRepository
    {
        public TrsManCreditRepository(DataContext context) : base(context)
        {
        }
    }
}
