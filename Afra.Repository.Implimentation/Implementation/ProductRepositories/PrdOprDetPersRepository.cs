using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class PrdOprDetPersRepository : Repository<PrdOprDetPers> , IPrdOprDetPersRepository
    {
        public PrdOprDetPersRepository(DataContext context) : base(context)
        {
        }
    }
}
