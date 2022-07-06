using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ElmntMethodRolesRepository : Repository<ElmntMethodRoles> , IElmntMethodRolesRepository
    {
        public ElmntMethodRolesRepository(DataContext context) : base(context)
        {
        }
    }
}
