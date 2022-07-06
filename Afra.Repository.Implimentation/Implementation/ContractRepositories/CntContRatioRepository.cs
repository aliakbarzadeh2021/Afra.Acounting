using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntContRatioRepository : Repository<CntContRatio> , ICntContRatioRepository
    {
        public CntContRatioRepository(DataContext context) : base(context)
        {
        }
    }
}
