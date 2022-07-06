using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrLCDetRepository : Repository<CmrLCDet> , ICmrLCDetRepository
    {
        public CmrLCDetRepository(DataContext context) : base(context)
        {
        }
    }
}
