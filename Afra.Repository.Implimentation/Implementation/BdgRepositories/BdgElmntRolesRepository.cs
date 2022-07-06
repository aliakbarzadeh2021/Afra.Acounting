using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgElmntRolesRepository : Repository<BdgElmntRoles> , IBdgElmntRolesRepository
    {
        public BdgElmntRolesRepository(DataContext context) : base(context)
        {
        }
    }
}
