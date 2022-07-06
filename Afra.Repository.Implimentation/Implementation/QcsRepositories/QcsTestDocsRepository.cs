using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class QcsTestDocsRepository : Repository<QcsTestDocs> , IQcsTestDocsRepository
    {
        public QcsTestDocsRepository(DataContext context) : base(context)
        {
        }
    }
}
