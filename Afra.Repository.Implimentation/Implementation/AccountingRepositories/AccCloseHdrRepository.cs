using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AccCloseHdrRepository : Repository<AccCloseHdr> , IAccCloseHdrRepository
    {
        public AccCloseHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
