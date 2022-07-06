using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntContDetRepository : Repository<CntContDet> , ICntContDetRepository
    {
        public CntContDetRepository(DataContext context) : base(context)
        {
        }
    }
}
