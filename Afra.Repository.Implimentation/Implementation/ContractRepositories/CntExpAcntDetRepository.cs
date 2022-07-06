using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntExpAcntDetRepository : Repository<CntExpAcntDet> , ICntExpAcntDetRepository
    {
        public CntExpAcntDetRepository(DataContext context) : base(context)
        {
        }
    }
}
