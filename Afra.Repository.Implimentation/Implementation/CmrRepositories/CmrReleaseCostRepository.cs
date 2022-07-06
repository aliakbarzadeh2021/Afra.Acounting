using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrReleaseCostRepository : Repository<CmrReleaseCost> , ICmrReleaseCostRepository
    {
        public CmrReleaseCostRepository(DataContext context) : base(context)
        {
        }
    }
}
