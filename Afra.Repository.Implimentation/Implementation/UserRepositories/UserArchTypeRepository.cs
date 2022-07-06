using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UserArchTypeRepository : Repository<UserArchType> , IUserArchTypeRepository
    {
        public UserArchTypeRepository(DataContext context) : base(context)
        {
        }
    }
}
