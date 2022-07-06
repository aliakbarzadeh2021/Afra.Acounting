using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFundBillItmRepository : Repository<TrsFundBillItm> , ITrsFundBillItmRepository
    {
        public TrsFundBillItmRepository(DataContext context) : base(context)
        {
        }
    }
}
