using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class QcsDocsRepository : Repository<QcsDocs> , IQcsDocsRepository
    {
        public QcsDocsRepository(DataContext context) : base(context)
        {
        }
    }
}
