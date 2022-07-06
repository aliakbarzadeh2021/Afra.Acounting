using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class InvPartGroupsRepository : Repository<InvPartGroups> , IInvPartGroupsRepository
    {
        public InvPartGroupsRepository(DataContext context) : base(context)
        {
        }
    }
}
