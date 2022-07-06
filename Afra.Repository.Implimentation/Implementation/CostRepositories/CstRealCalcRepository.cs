using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstRealCalcRepository : Repository<CstRealCalc> , ICstRealCalcRepository
    {
        public CstRealCalcRepository(DataContext context) : base(context)
        {
        }
    }
}
