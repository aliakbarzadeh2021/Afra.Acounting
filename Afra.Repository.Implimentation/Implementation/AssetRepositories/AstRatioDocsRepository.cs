using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class AstRatioDocsRepository : Repository<AstRatioDocs> , IAstRatioDocsRepository
    {
        public AstRatioDocsRepository(DataContext context) : base(context)
        {
        }
    }
}
