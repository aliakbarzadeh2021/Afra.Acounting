using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdOprDetRepository : Repository<PrdOprDet> , IPrdOprDetRepository
    {
        public PrdOprDetRepository(DataContext context) : base(context)
        {
        }
    }
}
