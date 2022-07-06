using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class UsGroupsRepository : Repository<UsGroups> , IUsGroupsRepository
    {
        public UsGroupsRepository(DataContext context) : base(context)
        {
        }
    }
}
