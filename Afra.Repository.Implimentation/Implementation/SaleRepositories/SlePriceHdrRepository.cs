using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class SlePriceHdrRepository : Repository<SlePriceHdr> , ISlePriceHdrRepository
    {
        public SlePriceHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
