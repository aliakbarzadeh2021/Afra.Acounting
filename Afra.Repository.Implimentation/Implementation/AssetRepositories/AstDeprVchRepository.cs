using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstDeprVchRepository : Repository<AstDeprVch> , IAstDeprVchRepository
    {
        public AstDeprVchRepository(DataContext context) : base(context)
        {
        }
    }
}
