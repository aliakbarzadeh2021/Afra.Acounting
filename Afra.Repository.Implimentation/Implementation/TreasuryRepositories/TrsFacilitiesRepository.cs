using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFacilitiesRepository : Repository<TrsFacilities> , ITrsFacilitiesRepository
    {
        public TrsFacilitiesRepository(DataContext context) : base(context)
        {
        }
    }
}
