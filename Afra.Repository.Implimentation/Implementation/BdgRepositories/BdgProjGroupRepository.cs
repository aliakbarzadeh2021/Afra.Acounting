using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgProjGroupRepository : Repository<BdgProjGroup> , IBdgProjGroupRepository
    {
        public BdgProjGroupRepository(DataContext context) : base(context)
        {
        }
    }
}
