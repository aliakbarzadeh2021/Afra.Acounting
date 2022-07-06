using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntExpAcntCostCntrRepository : Repository<CntExpAcntCostCntr> , ICntExpAcntCostCntrRepository
    {
        public CntExpAcntCostCntrRepository(DataContext context) : base(context)
        {
        }
    }
}
