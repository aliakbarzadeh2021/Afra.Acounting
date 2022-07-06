using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFacilitiesGuaRepository : Repository<TrsFacilitiesGua> , ITrsFacilitiesGuaRepository
    {
        public TrsFacilitiesGuaRepository(DataContext context) : base(context)
        {
        }
    }
}
