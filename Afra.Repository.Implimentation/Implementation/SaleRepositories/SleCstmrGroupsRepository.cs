using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleCstmrGroupsRepository : Repository<SleCstmrGroups> , ISleCstmrGroupsRepository
    {
        public SleCstmrGroupsRepository(DataContext context) : base(context)
        {
        }
    }
}
