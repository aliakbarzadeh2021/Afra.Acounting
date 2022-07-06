using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class QcsMensRepository : Repository<QcsMens> , IQcsMensRepository
    {
        public QcsMensRepository(DataContext context) : base(context)
        {
        }
    }
}
