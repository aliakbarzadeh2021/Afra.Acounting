using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsBankChqsDetRepository : Repository<TrsBankChqsDet> , ITrsBankChqsDetRepository
    {
        public TrsBankChqsDetRepository(DataContext context) : base(context)
        {
        }
    }
}
