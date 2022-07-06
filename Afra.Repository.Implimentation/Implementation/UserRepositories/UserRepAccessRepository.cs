using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UserRepAccessRepository : Repository<UserRepAccess> , IUserRepAccessRepository
    {
        public UserRepAccessRepository(DataContext context) : base(context)
        {
        }
    }
}
