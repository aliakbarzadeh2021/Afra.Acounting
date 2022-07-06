using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsGroupAccessRepository : Repository<UsGroupAccess> , IUsGroupAccessRepository
    {
        public UsGroupAccessRepository(DataContext context) : base(context)
        {
        }
    }
}
