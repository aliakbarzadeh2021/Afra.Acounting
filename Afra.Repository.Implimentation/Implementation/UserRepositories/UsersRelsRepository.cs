using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsersRelsRepository : Repository<UsersRels> , IUsersRelsRepository
    {
        public UsersRelsRepository(DataContext context) : base(context)
        {
        }
    }
}
