using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SleBranchsRepository : Repository<SleBranchs> , ISleBranchsRepository
    {
        public SleBranchsRepository(DataContext context) : base(context)
        {
        }
    }
}
