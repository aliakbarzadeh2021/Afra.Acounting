using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdPOrdItmDetRepository : Repository<PrdPOrdItmDet> , IPrdPOrdItmDetRepository
    {
        public PrdPOrdItmDetRepository(DataContext context) : base(context)
        {
        }
    }
}
