using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrReleaseItmRepository : Repository<CmrReleaseItm> , ICmrReleaseItmRepository
    {
        public CmrReleaseItmRepository(DataContext context) : base(context)
        {
        }
    }
}
