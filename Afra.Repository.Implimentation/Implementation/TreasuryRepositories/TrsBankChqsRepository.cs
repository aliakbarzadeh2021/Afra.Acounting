using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsBankChqsRepository : Repository<TrsBankChqs> , ITrsBankChqsRepository
    {
        public TrsBankChqsRepository(DataContext context) : base(context)
        {
        }
    }
}
