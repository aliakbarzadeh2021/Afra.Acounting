using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdSendHdrRepository : Repository<PrdSendHdr> , IPrdSendHdrRepository
    {
        public PrdSendHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
