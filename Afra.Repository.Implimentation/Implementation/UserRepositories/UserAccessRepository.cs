using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UserAccessRepository : Repository<UserAccess> , IUserAccessRepository
    {
        public UserAccessRepository(DataContext context) : base(context)
        {
        }
    }
}
