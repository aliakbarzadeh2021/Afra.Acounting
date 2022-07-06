using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrSendHdrRepository : Repository<CmrSendHdr> , ICmrSendHdrRepository
    {
        public CmrSendHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
