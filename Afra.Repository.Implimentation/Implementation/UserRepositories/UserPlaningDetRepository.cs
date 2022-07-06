using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UserPlaningDetRepository : Repository<UserPlaningDet> , IUserPlaningDetRepository
    {
        public UserPlaningDetRepository(DataContext context) : base(context)
        {
        }
    }
}
