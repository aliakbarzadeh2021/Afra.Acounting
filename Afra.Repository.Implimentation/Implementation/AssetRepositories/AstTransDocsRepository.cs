using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstTransDocsRepository : Repository<AstTransDocs> , IAstTransDocsRepository
    {
        public AstTransDocsRepository(DataContext context) : base(context)
        {
        }
    }
}
