using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntExpAcntValsRepository : Repository<CntExpAcntVals> , ICntExpAcntValsRepository
    {
        public CntExpAcntValsRepository(DataContext context) : base(context)
        {
        }
    }
}
