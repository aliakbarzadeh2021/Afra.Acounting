using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UserPlaningRepository : Repository<UserPlaning> , IUserPlaningRepository
    {
        public UserPlaningRepository(DataContext context) : base(context)
        {
        }
    }
}
