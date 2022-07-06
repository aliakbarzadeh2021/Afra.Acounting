using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsFundItmDetRepository : Repository<TrsFundItmDet> , ITrsFundItmDetRepository
    {
        public TrsFundItmDetRepository(DataContext context) : base(context)
        {
        }
    }
}
