using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrUserRoleRepository : Repository<GnrUserRole> , IGnrUserRoleRepository
    {
        public GnrUserRoleRepository(DataContext context) : base(context)
        {
        }
    }
}
