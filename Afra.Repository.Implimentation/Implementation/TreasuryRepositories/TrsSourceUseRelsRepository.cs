using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsSourceUseRelsRepository : Repository<TrsSourceUseRels> , ITrsSourceUseRelsRepository
    {
        public TrsSourceUseRelsRepository(DataContext context) : base(context)
        {
        }
    }
}
