using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class QcsMenLabsRepository : Repository<QcsMenLabs> , IQcsMenLabsRepository
    {
        public QcsMenLabsRepository(DataContext context) : base(context)
        {
        }
    }
}
