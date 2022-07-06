using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UserSignRightRepository : Repository<UserSignRight> , IUserSignRightRepository
    {
        public UserSignRightRepository(DataContext context) : base(context)
        {
        }
    }
}
