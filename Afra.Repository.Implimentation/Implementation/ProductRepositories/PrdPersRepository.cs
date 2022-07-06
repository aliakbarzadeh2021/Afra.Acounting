using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdPersRepository : Repository<PrdPers> , IPrdPersRepository
    {
        public PrdPersRepository(DataContext context) : base(context)
        {
        }
    }
}
