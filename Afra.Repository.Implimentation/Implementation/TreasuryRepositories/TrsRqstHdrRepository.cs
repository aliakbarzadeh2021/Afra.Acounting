using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsRqstHdrRepository : Repository<TrsRqstHdr> , ITrsRqstHdrRepository
    {
        public TrsRqstHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
