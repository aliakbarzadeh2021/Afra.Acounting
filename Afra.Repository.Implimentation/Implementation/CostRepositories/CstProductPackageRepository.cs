using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstProductPackageRepository : Repository<CstProductPackage> , ICstProductPackageRepository
    {
        public CstProductPackageRepository(DataContext context) : base(context)
        {
        }
    }
}
