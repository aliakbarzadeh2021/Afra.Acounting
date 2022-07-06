using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccSLDLRelRepository : Repository<AccSLDLRel> , IAccSLDLRelRepository
    {
        public AccSLDLRelRepository(DataContext context) : base(context)
        {
        }
    }
}
