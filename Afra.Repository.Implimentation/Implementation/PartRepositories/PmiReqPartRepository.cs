using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PmiReqPartRepository : Repository<PmiReqPart> , IPmiReqPartRepository
    {
        public PmiReqPartRepository(DataContext context) : base(context)
        {
        }
    }
}
