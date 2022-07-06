using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdMacroRepository : Repository<PrdMacro> , IPrdMacroRepository
    {
        public PrdMacroRepository(DataContext context) : base(context)
        {
        }
    }
}
