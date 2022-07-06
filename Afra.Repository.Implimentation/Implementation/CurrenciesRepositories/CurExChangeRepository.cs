using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CurExChangeRepository : Repository<CurExChange> , ICurExChangeRepository
    {
        public CurExChangeRepository(DataContext context) : base(context)
        {
        }
    }
}
