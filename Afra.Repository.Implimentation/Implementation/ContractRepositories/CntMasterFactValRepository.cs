using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntMasterFactValRepository : Repository<CntMasterFactVal> , ICntMasterFactValRepository
    {
        public CntMasterFactValRepository(DataContext context) : base(context)
        {
        }
    }
}
