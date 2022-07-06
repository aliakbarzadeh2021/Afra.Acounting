using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class QcsTestDetRepository : Repository<QcsTestDet> , IQcsTestDetRepository
    {
        public QcsTestDetRepository(DataContext context) : base(context)
        {
        }
    }
}
