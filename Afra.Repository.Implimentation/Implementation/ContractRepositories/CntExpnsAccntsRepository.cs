using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntExpnsAccntsRepository : Repository<CntExpnsAccnts> , ICntExpnsAccntsRepository
    {
        public CntExpnsAccntsRepository(DataContext context) : base(context)
        {
        }
    }
}
