using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UserProcessRepository : Repository<UserProcess> , IUserProcessRepository
    {
        public UserProcessRepository(DataContext context) : base(context)
        {
        }
    }
}
