using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrRef2FormLinkExpRepository : Repository<GnrRef2FormLinkExp> , IGnrRef2FormLinkExpRepository
    {
        public GnrRef2FormLinkExpRepository(DataContext context) : base(context)
        {
        }
    }
}
