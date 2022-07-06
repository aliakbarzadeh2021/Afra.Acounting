using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFacYearShareRepository : Repository<TrsFacYearShare> , ITrsFacYearShareRepository
    {
        public TrsFacYearShareRepository(DataContext context) : base(context)
        {
        }
    }
}
