using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class OtoBaseTypeValsRepository : Repository<OtoBaseTypeVals> , IOtoBaseTypeValsRepository
    {
        public OtoBaseTypeValsRepository(DataContext context) : base(context)
        {
        }
    }
}
