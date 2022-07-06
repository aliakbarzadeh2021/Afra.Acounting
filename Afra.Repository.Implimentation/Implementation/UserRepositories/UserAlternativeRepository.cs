using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UserAlternativeRepository : Repository<UserAlternative> , IUserAlternativeRepository
    {
        public UserAlternativeRepository(DataContext context) : base(context)
        {
        }
    }
}
