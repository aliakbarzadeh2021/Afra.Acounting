using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class QcsVchHdrRepository : Repository<QcsVchHdr> , IQcsVchHdrRepository
    {
        public QcsVchHdrRepository(DataContext context) : base(context)
        {
        }
    }
}
