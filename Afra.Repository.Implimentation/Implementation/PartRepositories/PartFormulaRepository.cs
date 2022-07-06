using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PartFormulaRepository : Repository<PartFormula> , IPartFormulaRepository
    {
        public PartFormulaRepository(DataContext context) : base(context)
        {
        }
    }
}
