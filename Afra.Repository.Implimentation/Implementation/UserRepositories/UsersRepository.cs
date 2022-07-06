using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsersRepository : Repository<Users> , IUsersRepository
    {
        public UsersRepository(DataContext context) : base(context)
        {
        }
    }
}
