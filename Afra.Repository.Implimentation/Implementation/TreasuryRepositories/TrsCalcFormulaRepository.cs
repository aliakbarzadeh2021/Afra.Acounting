using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class TrsCalcFormulaRepository : Repository<TrsCalcFormula> , ITrsCalcFormulaRepository
    {
        public TrsCalcFormulaRepository(DataContext context) : base(context)
        {
        }
    }
}
