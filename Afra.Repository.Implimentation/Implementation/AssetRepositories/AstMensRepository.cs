using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstMensRepository : Repository<AstMens> , IAstMensRepository
    {
        public AstMensRepository(DataContext context) : base(context)
        {
        }
    }
}
