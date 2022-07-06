using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntContTextRepository : Repository<CntContText> , ICntContTextRepository
    {
        public CntContTextRepository(DataContext context) : base(context)
        {
        }
    }
}
