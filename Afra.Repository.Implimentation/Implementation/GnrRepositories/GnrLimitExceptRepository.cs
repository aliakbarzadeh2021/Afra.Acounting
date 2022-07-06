using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrLimitExceptRepository : Repository<GnrLimitExcept> , IGnrLimitExceptRepository
    {
        public GnrLimitExceptRepository(DataContext context) : base(context)
        {
        }
    }
}
