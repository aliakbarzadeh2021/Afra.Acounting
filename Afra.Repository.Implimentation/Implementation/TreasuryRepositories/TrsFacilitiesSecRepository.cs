using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFacilitiesSecRepository : Repository<TrsFacilitiesSec> , ITrsFacilitiesSecRepository
    {
        public TrsFacilitiesSecRepository(DataContext context) : base(context)
        {
        }
    }
}
