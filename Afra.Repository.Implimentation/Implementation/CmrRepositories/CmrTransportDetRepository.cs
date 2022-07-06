using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrTransportDetRepository : Repository<CmrTransportDet> , ICmrTransportDetRepository
    {
        public CmrTransportDetRepository(DataContext context) : base(context)
        {
        }
    }
}
