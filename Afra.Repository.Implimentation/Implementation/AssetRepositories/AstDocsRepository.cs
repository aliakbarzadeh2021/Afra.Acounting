using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstDocsRepository : Repository<AstDocs> , IAstDocsRepository
    {
        public AstDocsRepository(DataContext context) : base(context)
        {
        }
    }
}
