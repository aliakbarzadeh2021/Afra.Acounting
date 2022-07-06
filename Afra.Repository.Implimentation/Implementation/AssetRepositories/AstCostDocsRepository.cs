using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstCostDocsRepository : Repository<AstCostDocs> , IAstCostDocsRepository
    {
        public AstCostDocsRepository(DataContext context) : base(context)
        {
        }
    }
}
