using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdVchInvDetRepository : Repository<PrdVchInvDet> , IPrdVchInvDetRepository
    {
        public PrdVchInvDetRepository(DataContext context) : base(context)
        {
        }
    }
}
