using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrFactItmRepository : Repository<CmrFactItm> , ICmrFactItmRepository
    {
        public CmrFactItmRepository(DataContext context) : base(context)
        {
        }
    }
}
