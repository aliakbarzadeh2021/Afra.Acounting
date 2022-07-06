using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFundsRepository : Repository<TrsFunds> , ITrsFundsRepository
    {
        public TrsFundsRepository(DataContext context) : base(context)
        {
        }
    }
}
