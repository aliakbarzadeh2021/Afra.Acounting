using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class StkStockDocsRepository : Repository<StkStockDocs> , IStkStockDocsRepository
    {
        public StkStockDocsRepository(DataContext context) : base(context)
        {
        }
    }
}
