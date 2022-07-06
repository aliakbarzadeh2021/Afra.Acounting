using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrPOrderItmRepository : Repository<CmrPOrderItm> , ICmrPOrderItmRepository
    {
        public CmrPOrderItmRepository(DataContext context) : base(context)
        {
        }
    }
}
