using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class QcsVchItmRepository : Repository<QcsVchItm> , IQcsVchItmRepository
    {
        public QcsVchItmRepository(DataContext context) : base(context)
        {
        }
    }
}
