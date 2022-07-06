using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsCostFactorsRepository : Repository<TrsCostFactors> , ITrsCostFactorsRepository
    {
        public TrsCostFactorsRepository(DataContext context) : base(context)
        {
        }
    }
}
