using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstAccDataRepository : Repository<CstAccData> , ICstAccDataRepository
    {
        public CstAccDataRepository(DataContext context) : base(context)
        {
        }
    }
}
