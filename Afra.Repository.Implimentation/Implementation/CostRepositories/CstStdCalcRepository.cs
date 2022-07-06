using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstStdCalcRepository : Repository<CstStdCalc> , ICstStdCalcRepository
    {
        public CstStdCalcRepository(DataContext context) : base(context)
        {
        }
    }
}
