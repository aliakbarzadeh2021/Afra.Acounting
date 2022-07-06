using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class GnrRef2FormLinksItmRepository : Repository<GnrRef2FormLinksItm> , IGnrRef2FormLinksItmRepository
    {
        public GnrRef2FormLinksItmRepository(DataContext context) : base(context)
        {
        }
    }
}
