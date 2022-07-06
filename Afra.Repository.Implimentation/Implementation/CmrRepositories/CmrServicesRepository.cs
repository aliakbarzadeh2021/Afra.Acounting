using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrServicesRepository : Repository<CmrServices> , ICmrServicesRepository
    {
        public CmrServicesRepository(DataContext context) : base(context)
        {
        }
    }
}
