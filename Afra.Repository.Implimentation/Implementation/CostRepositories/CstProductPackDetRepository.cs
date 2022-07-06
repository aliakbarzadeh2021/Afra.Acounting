using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CstProductPackDetRepository : Repository<CstProductPackDet> , ICstProductPackDetRepository
    {
        public CstProductPackDetRepository(DataContext context) : base(context)
        {
        }
    }
}
