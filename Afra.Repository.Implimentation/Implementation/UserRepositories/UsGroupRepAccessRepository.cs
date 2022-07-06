using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsGroupRepAccessRepository : Repository<UsGroupRepAccess> , IUsGroupRepAccessRepository
    {
        public UsGroupRepAccessRepository(DataContext context) : base(context)
        {
        }
    }
}
