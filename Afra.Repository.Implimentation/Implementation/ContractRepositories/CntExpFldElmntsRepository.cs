using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntExpFldElmntsRepository : Repository<CntExpFldElmnts> , ICntExpFldElmntsRepository
    {
        public CntExpFldElmntsRepository(DataContext context) : base(context)
        {
        }
    }
}
