using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class BdgPartsDetRepository : Repository<BdgPartsDet> , IBdgPartsDetRepository
    {
        public BdgPartsDetRepository(DataContext context) : base(context)
        {
        }
    }
}
