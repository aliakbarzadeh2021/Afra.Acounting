using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CntContElmntRepository : Repository<CntContElmnt> , ICntContElmntRepository
    {
        public CntContElmntRepository(DataContext context) : base(context)
        {
        }
    }
}
