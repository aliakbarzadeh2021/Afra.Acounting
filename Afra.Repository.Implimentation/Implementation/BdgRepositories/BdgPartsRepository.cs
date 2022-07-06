using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgPartsRepository : Repository<BdgParts> , IBdgPartsRepository
    {
        public BdgPartsRepository(DataContext context) : base(context)
        {
        }
    }
}
