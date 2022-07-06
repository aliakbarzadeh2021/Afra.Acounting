using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstElmntRolesRepository : Repository<CstElmntRoles> , ICstElmntRolesRepository
    {
        public CstElmntRolesRepository(DataContext context) : base(context)
        {
        }
    }
}
