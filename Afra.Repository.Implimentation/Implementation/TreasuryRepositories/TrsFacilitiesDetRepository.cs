using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFacilitiesDetRepository : Repository<TrsFacilitiesDet> , ITrsFacilitiesDetRepository
    {
        public TrsFacilitiesDetRepository(DataContext context) : base(context)
        {
        }
    }
}
