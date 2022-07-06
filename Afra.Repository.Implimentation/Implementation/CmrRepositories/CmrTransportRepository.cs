using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrTransportRepository : Repository<CmrTransport> , ICmrTransportRepository
    {
        public CmrTransportRepository(DataContext context) : base(context)
        {
        }
    }
}
