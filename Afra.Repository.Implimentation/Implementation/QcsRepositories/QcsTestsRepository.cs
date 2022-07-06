using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class QcsTestsRepository : Repository<QcsTests> , IQcsTestsRepository
    {
        public QcsTestsRepository(DataContext context) : base(context)
        {
        }
    }
}
