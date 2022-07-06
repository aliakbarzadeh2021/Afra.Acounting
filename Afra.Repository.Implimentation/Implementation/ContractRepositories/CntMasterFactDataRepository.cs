using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntMasterFactDataRepository : Repository<CntMasterFactData> , ICntMasterFactDataRepository
    {
        public CntMasterFactDataRepository(DataContext context) : base(context)
        {
        }
    }
}
