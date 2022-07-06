using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PartFormulaDetRepository : Repository<PartFormulaDet> , IPartFormulaDetRepository
    {
        public PartFormulaDetRepository(DataContext context) : base(context)
        {
        }
    }
}
