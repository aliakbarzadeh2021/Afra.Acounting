using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class QcsRequestRepository : Repository<QcsRequest> , IQcsRequestRepository
    {
        public QcsRequestRepository(DataContext context) : base(context)
        {
        }
    }
}
