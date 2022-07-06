using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrRef2FormLinkHdrRepository : Repository<GnrRef2FormLinkHdr> , IGnrRef2FormLinkHdrRepository
    {
        public GnrRef2FormLinkHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
