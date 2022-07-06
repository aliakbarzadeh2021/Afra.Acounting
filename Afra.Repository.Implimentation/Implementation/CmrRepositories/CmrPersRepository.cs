using Afra.Domain.Entities;
using Afra.Repository.Repositories;

namespace Afra.Repository.Implimentation.Implementation
{
    public class CmrPersRepository : Repository<CmrPers> , ICmrPersRepository
    {
        public CmrPersRepository(DataContext context) : base(context)
        {
        }
    }
}
