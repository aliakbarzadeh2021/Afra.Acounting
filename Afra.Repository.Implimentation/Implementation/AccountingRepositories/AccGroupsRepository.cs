using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccGroupsRepository : Repository<AccGroups> , IAccGroupsRepository
    {
        public AccGroupsRepository(DataContext context) : base(context)
        {
        }
    }
}
