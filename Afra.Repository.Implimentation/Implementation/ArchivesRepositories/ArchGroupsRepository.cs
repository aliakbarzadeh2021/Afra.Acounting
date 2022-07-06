using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class ArchGroupsRepository : Repository<ArchGroups> , IArchGroupsRepository
    {
        public ArchGroupsRepository(DataContext context) : base(context)
        {
        }
    }
}
