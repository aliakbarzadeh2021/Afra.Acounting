using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UserPlaningDetInfRepository : Repository<UserPlaningDetInf> , IUserPlaningDetInfRepository
    {
        public UserPlaningDetInfRepository(DataContext context) : base(context)
        {
        }
    }
}
